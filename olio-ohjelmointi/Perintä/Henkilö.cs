using System;
using System.Collections.Generic;
using System.Text;

namespace Perintä
{
    class Henkilö
    {
        public string Nimi;
        public int Ikä;
        public int Henkilötunnus;

        private static int instanssit = 0;

        public Henkilö(string nimi, int ikä, int henkilötunnus)
        {
            Nimi = nimi;
            Ikä = ikä;
            Henkilötunnus = henkilötunnus;

            instanssit++;
        }

        public virtual void Tulostatiedot()
        {
            Console.WriteLine("Henkilö: " + Nimi + ". Ikä: " + Ikä + ". Henkilötunnus: " + Henkilötunnus);
        }

        public void Syö()
        {
            Console.WriteLine(Nimi + " syö..");
        }
        public static void KuinkaMontaHenkilöä()
        {
            Console.WriteLine("Henkilöitä on olemassa: " + instanssit);

        }
    }
}
