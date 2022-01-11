using System;

namespace Kotitehtävä2
{
    class Program
    {
        static void Main(string[] args)
        {
            Kappale kappale = new Kappale("Schizophrenic", "3:07", "Night Club");
            Radioasema taajuus = new Radioasema(88, 108);
            string syöte;

            while (true)
            {
                Console.WriteLine("Olet Radiokanavalla " + taajuus.NykyinenTaajuus);
                kappale.LisääKappale(new Kappale("Schizophrenic", "3:07","Night Club"));
                Console.WriteLine("Mihin kanavaan haluat siirtyä");
                syöte = Console.ReadLine();

                if (syöte == "Poistu")
                {
                    Console.WriteLine("Poistut Radiosta");
                    break;
                }
                else
                {
                    taajuus.NykyinenTaajuus = int.Parse(syöte);
                }
            }
        }    
    }
}
