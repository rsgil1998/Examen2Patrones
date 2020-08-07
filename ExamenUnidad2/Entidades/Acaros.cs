using ExamenUnidad2.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad2.Entidades
{
    public class Acaros : IComponete
    {
        private IComponete decoramosA;
        public Acaros(IComponete componete)
        {
            decoramosA = componete;
        }
        public double CostoProducionPorMata()
        {
            return decoramosA.CostoProducionPorMata() + 0.20;
        }

        
    }
}
