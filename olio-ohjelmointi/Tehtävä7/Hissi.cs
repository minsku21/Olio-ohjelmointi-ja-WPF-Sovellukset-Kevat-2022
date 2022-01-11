using System;
using System.Collections.Generic;
using System.Text;

namespace Tehtävä7
{
    class Hissi
    {
        private int minkerros;
        private int maxKerros;

        private int nykyinenKerros;

        public Hissi(int minkerros, int maxKerros)
        {
            this.minkerros = minkerros;
            this.maxKerros = maxKerros;

            NykyinenKerros = minkerros;
        }

        public int NykyinenKerros
        {
            get => nykyinenKerros;
            set
            {
                if (value > maxKerros || value < minkerros)
                {
                    Console.WriteLine("Virheellinen Kerros");
                }
                else
                {
                    nykyinenKerros = value;
                }
            }
        }
    }
}
