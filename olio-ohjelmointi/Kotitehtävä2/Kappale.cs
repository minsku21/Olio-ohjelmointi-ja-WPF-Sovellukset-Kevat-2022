using System;
using System.Collections.Generic;
using System.Text;

namespace Kotitehtävä2
{
    class Kappale
    {
        public string Nimi;
        public float taajuus;

        public Kappale(string nimi, float taajuus)
        {
            Nimi = nimi;
            this.taajuus = taajuus;
        }
    }
}
