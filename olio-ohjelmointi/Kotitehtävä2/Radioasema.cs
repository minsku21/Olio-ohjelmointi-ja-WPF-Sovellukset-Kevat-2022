using System;
using System.Collections.Generic;
using System.Text;

namespace Kotitehtävä2
{
    class Radioasema
    {
        private int minTaajuus;
        private int maxTaajuus;

        private int nykyinenTaajuus;

        public Radioasema(int mintaajuus, int maxtaajuus)
        {
            this.minTaajuus = mintaajuus;
            this.maxTaajuus = maxtaajuus;

            NykyinenTaajuus = mintaajuus;
        }

        public int NykyinenTaajuus
        {
            get => nykyinenTaajuus;
            set
            {
                if (value > maxTaajuus || value < minTaajuus)
                {
                    Console.WriteLine("Virheellinen Taajuus");
                }
                else
                {
                    nykyinenTaajuus = value;
                }
            }
        }
    }
}
