using System;

namespace ajoneuvot
{
    class Program
    {
        static void Main(string[] args)
        {
            Ajoneuvo ajoneuvo1 = new Ajoneuvo();
            ajoneuvo1.nimi = "Moottoripyörä";
            ajoneuvo1.nopeus = 45;
            ajoneuvo1.renkaat = 3;

            ajoneuvo1.TulosData();
        }
    }
}
