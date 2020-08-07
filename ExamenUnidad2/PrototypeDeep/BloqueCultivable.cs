using ExamenUnidad2.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad2.PrototypeDeep
{
    public class BloqueCultivable: ICloneable
    {
        public int id { get; set; }
        public int camas { get; set; }
        public string encargado { get; set; }
        public int numMatas { get; set; }
         
        public BloqueCultivable(int i,int cam,int num,string encarga)
        {
            id = i;
            camas = cam;
            numMatas = num;
            encargado = encarga;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public override string ToString()
        {
            return id + "\t" + camas + "\t" + numMatas + "\t" + encargado;
        }

    }
}
