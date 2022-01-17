using System;
using System.Collections.Generic;
using System.Text;

namespace SM_Liiga
{
    class Pelaaja
    {
        public string Etunimi;
        public string Sukunimi;
        public int PelaajaNumero;

        public Pelaaja(string etunimi, string sukunimi, int pelaajaNumero)
        {
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            PelaajaNumero = pelaajaNumero;
        }
    }
}
