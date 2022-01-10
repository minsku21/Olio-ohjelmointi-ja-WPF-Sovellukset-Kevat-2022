using System;

namespace testapp
{
    class Program
    {
        static void Main(string[] args)
        {
            koira koira1 = new koira();
            koira1.nimi = "Tiitus";
            koira1.ikä = 4;
            koira1.rotu = "Mainecoon";

            koira1.Mauku();
            koira1.TulosData();

            koira koira2 = new koira();

            koira2.nimi = "Vinski";
            koira2.ikä = 9;
            koira2.rotu = "Ragdoll";

            koira2.TulosData();

            koira koira3 = new koira("Laku", 5, "Mopsi");
            koira3.TulosData();
        }
    }
}
