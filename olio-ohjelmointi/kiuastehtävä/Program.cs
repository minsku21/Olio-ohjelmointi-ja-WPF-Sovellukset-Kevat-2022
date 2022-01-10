using System;

namespace kiuastehtävä
{
    class Program
    {
        static void Main(string[] args)
        {
            Kiuas harvia = new Kiuas("Harvia", 99, 50);

            harvia.NäytäTiedot();
            harvia.Tila = true;
            harvia.NäytäTiedot();
            harvia.SäädäLämpötila(100);
            harvia.NäytäTiedot();

        }
    }
}
