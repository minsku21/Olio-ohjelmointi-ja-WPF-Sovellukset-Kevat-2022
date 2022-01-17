using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_11
{
    class Opiskelija
    {
        public string Etunimi;
        public string Sukunimi;
        public string RyhmäTunnus;
        public int OpiskelijaNumero;

        public void TulostaTiedot()
        {
            Console.WriteLine("Opiskelija: {0} {1}. Ryhmätunnus: {2}. opiskelijanumero {3} ", Etunimi, Sukunimi, RyhmäTunnus, OpiskelijaNumero);
        }
    }
}
