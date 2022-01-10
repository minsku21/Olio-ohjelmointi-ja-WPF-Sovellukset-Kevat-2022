using System;
using System.Collections.Generic;
using System.Text;

namespace Albumitehtävä
{
    class Albumi
    {
        private string Artisti;
        private string Nimi;
        private string Genre;
        private string Hinta;


        private List<Kappale> kappaleet = new List<Kappale>();
        private string v1;
        private string v2;
        private string v3;

        public Albumi(string v1, string v2, string v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public Albumi(string artisti, string nimi, string genre, string hinta)
        {
            Artisti = artisti;
            Nimi = nimi;
            Genre = genre;
            Hinta = hinta;
        }

        public void LisääKappale(Kappale uusikappale)
        {
            kappaleet.Add(uusikappale);
        }
        public void TulostaKappaleet()
        {
            foreach(Kappale kappale in kappaleet)
            {
                Console.WriteLine(kappale.Nimi + "," + kappale.Pituus);
            }
        }

    }
}
