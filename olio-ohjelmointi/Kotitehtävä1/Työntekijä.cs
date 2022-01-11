using System;
using System.Collections.Generic;
using System.Text;

namespace Kotitehtävä1
{
    class Työntekijä : Henkilö
    {
        public int Tunti;

        private static int instanssit = 0;

        public Työntekijä(string nimi, string työpaikka, int palkka, int tunti) : base(nimi, työpaikka, palkka)
        {
            Tunti = tunti;

            instanssit++;
        }
        public override void Tulostatiedot()
        {
            Console.WriteLine("Pomo: " + Nimi + ". Palkka: " + Palkka + ". Tunti: " + Tunti);
        }
        public static void KuinkaMontaTyöntekijää()
        {
            Console.WriteLine("Pomoja on olemassa: " + instanssit);
        }
    }
}
