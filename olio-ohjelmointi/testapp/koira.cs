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

        public koira() { }

        public koira(string _nimi, int _ikä, string _rotu)
        {
            nimi = _nimi;
            ikä = _ikä;
            rotu = _rotu;

            Mauku();
        }
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
