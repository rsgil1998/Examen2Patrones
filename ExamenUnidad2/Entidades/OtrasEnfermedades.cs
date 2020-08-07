using ExamenUnidad2.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad2.Entidades
{
    public class OtrasEnfermedades : IComponete
    {
        private IComponete decoramosA;
        public OtrasEnfermedades(IComponete componete)
        {
            decoramosA = componete;
        }
        public double CostoProducionPorMata()
        {
            return decoramosA.CostoProducionPorMata() + 0.15;
        }
    }
}
