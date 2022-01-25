using System;
using System.Collections.Generic;

namespace Kotitehtävä2
{
    class Program
    {
        static void Main(string[] args)
        {
            Kappale kappale = new Kappale("Schizophrenic", 99.0f);
            List<Kappale> kanavat = new List<Kappale>();
            kanavat.Add(kappale);
            Radioasema radio = new Radioasema(88, 108);
            string syöte;

            while (true)
            {
                Console.WriteLine("Olet taajuudella: " + radio.NykyinenTaajuus);
                foreach (var item in kanavat)
                {
                    if (item.taajuus == radio.NykyinenTaajuus)
                    {
                        Console.WriteLine("Radiokanava: " + item.Nimi);
                    }
                }
                Console.WriteLine("Mihin kanavaan haluat siirtyä");
                syöte = Console.ReadLine();

                if (syöte == "Poistu")
                {
                    Console.WriteLine("Poistut Radiosta");
                    break;
                }
                else
                {
                    radio.NykyinenTaajuus = int.Parse(syöte);
                }
            }
        }    
    }
}
