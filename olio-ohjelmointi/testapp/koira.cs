using System;
using System.Collections.Generic;
using System.Text;

namespace testapp
{
    class koira
    {
        public string nimi;
        public int ikä;
        public string rotu;

        public void TulosData()
        {
            Console.WriteLine("koiran nimi: " + nimi + ". ikä: " + ikä + ". Rotu: " + rotu);
        }
        public void Mauku()
        {
            Console.WriteLine("Meow");
        }
    }
}
