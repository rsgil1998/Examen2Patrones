using ExamenUnidad2.Decorator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad2.Entidades
{
    public class Variedad:IComponete
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int cantidadMatas { get; set; }
        public double CostoPorMata { get; set; }
        
        public Variedad(int identificador,string nombreVariedad,double costo,int cantidad) {
            this.id = identificador;
            this.nombre = nombreVariedad;
            this.cantidadMatas = cantidad;
            this.CostoPorMata = costo;
        }

        public double CostoProducionPorMata()
        {
            return CostoPorMata;
        }

        public override string ToString()
        {
            return id + "\t" + nombre + "\t" + cantidadMatas + "\t" + CostoPorMata;
        }
        

    }
}
