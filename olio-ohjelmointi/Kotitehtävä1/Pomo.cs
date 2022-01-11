using System;
using System.Collections.Generic;
using System.Text;

namespace Kotitehtävä1
{
    class Pomo : Henkilö
    {
        public string Auto;
        public int Bonus;

        private static int instanssit = 0;

        public Pomo(string nimi, string työpaikka, int palkka, string auto, int bonus) : base(nimi, työpaikka, palkka)
        {
            if(instanssit > 0)
            {
                Console.WriteLine("Voi olla vain yksi pomo");
                return;
            }
            Auto = auto;
            Bonus = bonus;

            instanssit++;
        }
        public override void Tulostatiedot()
        {
            Console.WriteLine("Pomo: " + Nimi + ". Palkka: " + Palkka + ". Auto: " + Auto + ".Bonus: " + Bonus);
        }
        public static void KuinkaMontaPomoa()
        {
            Console.WriteLine("Pomoja on olemassa: " + instanssit);
        }
    }
}
