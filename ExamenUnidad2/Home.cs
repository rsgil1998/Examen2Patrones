using ExamenUnidad2.Decorator;
using ExamenUnidad2.Entidades;
using ExamenUnidad2.PrototypeDeep;
using ExamenUnidad2.Singleton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenUnidad2
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        SingletonConfig config = SingletonConfig.GetSingletonConfig();
        BloqueCultivable OBloque;
        BloqueCultivable CBloque;
        int idBloque=1;
        int idVariedad=1;
        List<Variedad> variedades = new List<Variedad>();
        IComponete miVariedad;
        private void Home_Load(object sender, EventArgs e)
        {
            OBloque = new BloqueCultivable(idBloque, 100, 3000, "Jorge");
            lblMedidas.Text = config.medidas;
            lblnombreFloricola.Text = config.nombreFloricola;
            lblTallosXBonche.Text = config.tallosPorBonche.ToString();
            numBloCam.Value = OBloque.camas;            
            numBloMa.Value = OBloque.numMatas;
            txtEncargado.Text = OBloque.encargado;            
            lstBloques.Items.Add(OBloque);
            cmbBloque.Items.Add(OBloque.id);
            ColocarEnfermedadesEnCmb();
            cmbBloque.SelectedIndex = 0;
            miVariedad = new Variedad(idVariedad, "Explorer", 0.15, 3000);
            lstVariedades.Items.Add(miVariedad);
            cmbVariedad.Items.Add(((Variedad)miVariedad).nombre);
            variedades.Add(((Variedad)miVariedad));
            cmbVariedad.SelectedIndex = 0;
            cmbEnfermedad.SelectedIndex = 0;

        }

        private void btnClonar_Click(object sender, EventArgs e)
        {
            idBloque++;
            CBloque = OBloque.Clone() as BloqueCultivable;
            CBloque.id = idBloque;
            CBloque.numMatas = (int)numBloMa.Value;
            CBloque.camas = (int)numBloCam.Value;
            CBloque.encargado = txtEncargado.Text;
            lstBloques.Items.Add(CBloque);            
            cmbBloque.Items.Add(CBloque.id);
        }
        public void ColocarEnfermedadesEnCmb()
        {
            cmbEnfermedad.Items.Add("Acaros");
            cmbEnfermedad.Items.Add("Botrytis");
            cmbEnfermedad.Items.Add("Velloso");
            cmbEnfermedad.Items.Add("Otras enfermedades");
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {                
                    idVariedad++;
                    miVariedad = new Variedad(idVariedad, txtVarNombre.Text, (double)numVarCos.Value, (int)numVarMa.Value);
                    lstVariedades.Items.Add(miVariedad);
                    cmbVariedad.Items.Add(((Variedad)miVariedad).nombre);
                    variedades.Add(((Variedad)miVariedad));
        }

        private void btnDar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <lstVariedades.Items.Count; i++)
            {
                if (cmbVariedad.SelectedIndex.ToString()==variedades[i].nombre.ToString())
                {
                    miVariedad = variedades[i];
                }
            }
            
            switch (cmbEnfermedad.SelectedIndex)
            {
                case 0:
                    miVariedad = new Acaros(miVariedad);
                    break;
                case 1:
                    miVariedad = new Botrytis(miVariedad);
                    break;
                case 2:
                    miVariedad = new Velloso(miVariedad);
                    break;
                case 3:
                    miVariedad = new OtrasEnfermedades(miVariedad);
                    break;
                default:
                    // code block
                    break;
            }
            lblCostoEnfer.Text = miVariedad.CostoProducionPorMata().ToString();
        }
    }
}
