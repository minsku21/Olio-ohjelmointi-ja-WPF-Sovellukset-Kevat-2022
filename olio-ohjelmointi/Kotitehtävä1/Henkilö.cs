using System;
using System.Collections.Generic;
using System.Text;

namespace Kotitehtävä1
{
    abstract class Henkilö
    {
        public string Nimi;
        public string Työpaikka;
        public int Palkka;

        private static int instanssit = 0;

        public Henkilö(string nimi, string työpaikka, int palkka)
        {
            Nimi = nimi;
            Työpaikka = työpaikka;
            Palkka = palkka;

            instanssit++;
        }
        public virtual void Tulostatiedot()
        {
            Console.WriteLine("Henkilö: " + Nimi + ". Työpaikka: " + Työpaikka + ". Palkka" + Palkka);
        }
        public static void KuinkaMontaHenkilöä()
        {
            Console.WriteLine("Henkilöitä on olemassa: " + instanssit);

        }
    }
}
