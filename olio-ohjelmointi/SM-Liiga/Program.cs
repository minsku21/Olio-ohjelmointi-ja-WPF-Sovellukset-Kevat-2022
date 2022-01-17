using System;
using System.Collections.Generic;

namespace SM_Liiga
{
    class Program
    {
        static void Main(string[] args)
        {
            Joukkue joukkue1 = new Joukkue("Hoc", "Porvoo");

            Pelaaja pelaaja1 = new Pelaaja("Tiitus", "S", 5);
            Pelaaja pelaaja2 = new Pelaaja("Vinski", "S", 11);
            Pelaaja pelaaja3 = new Pelaaja("Luke", "A", 17);

            joukkue1.LisääPelaaja(pelaaja1);
            joukkue1.LisääPelaaja(pelaaja2);
            joukkue1.LisääPelaaja(pelaaja3);

            foreach (Pelaaja pelaaja in joukkue1.HaePelaajat())
            {
                Console.WriteLine(pelaaja.Etunimi);
            }
        }
    }
}
