using System;
using System.Collections.Generic;
using System.Text;

namespace ajoneuvot
{
    class Ajoneuvo
    {
        public string nimi;
        public int nopeus;
        public int renkaat;

        public void TulosData()
        {
            Console.WriteLine("Ajoneuvon nimi: " + nimi);
            Console.WriteLine("Ajoneuvon nopeus: " + nopeus);
            Console.WriteLine("Ajoneuvon renkaat: " + renkaat);


        }
        public string ToString()
        {
            return "Ajoneuvo: " + nimi + ". Nopeus: " + nopeus + ". Renkaiden määrä: " + renkaat;
        }
    }
}
