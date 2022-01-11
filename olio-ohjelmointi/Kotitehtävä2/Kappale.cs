using System;
using System.Collections.Generic;
using System.Text;

namespace Kotitehtävä2
{
    class Kappale
    {
        public string Nimi;
        public string Pituus;
        public string Artisti;

        private List<Kappale> kappaleet = new List<Kappale>();
        private string v1;

        public Kappale(string _nimi, string _pituus, string _Artisti)
        {
            Nimi = _nimi;
            Pituus = _pituus;
            Artisti = _Artisti;
        }
        public void LisääKappale(Kappale uusikappale)
        {
            kappaleet.Add(uusikappale);
        }
        public void TulostaKappaleet()
        {
            foreach (Kappale kappale in kappaleet)
            {
                Console.WriteLine(kappale.Nimi + "," + kappale.Pituus);
            }
        }
    }
}
