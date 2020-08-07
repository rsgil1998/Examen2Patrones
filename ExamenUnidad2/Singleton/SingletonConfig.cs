using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad2.Singleton
{
    public sealed class SingletonConfig
    {
        private static SingletonConfig froricola;
        public string nombreFloricola { get; set; }
        public int tallosPorBonche { get; set; }
        public string medidas { get; set; }


        private SingletonConfig()
        {
         this.nombreFloricola = " FlorDelCajas";
         this.tallosPorBonche = 25;
         this.medidas = "40,50,60,70,80,90,100,110,120";
        }

        private static void CreateSingletonConfig()
        {
            if (froricola == null)
            {
                froricola = new SingletonConfig();
            }
        }
        public static SingletonConfig GetSingletonConfig()
        {
            if (froricola == null)
            {
                CreateSingletonConfig();
            }
            return froricola;
        }
    }
}
