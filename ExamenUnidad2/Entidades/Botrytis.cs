using ExamenUnidad2.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad2.Entidades
{
    public class Botrytis : IComponete
    {
        private IComponete decoramosA;
        public Botrytis(IComponete componete)
        {
            decoramosA = componete;
        }
        public double CostoProducionPorMata()
        {
            return decoramosA.CostoProducionPorMata() + 0.10;
        }
    }
}
