using System;
using System.Collections.Generic;

namespace Harjoitus_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Opiskelija> opiskelijat = new Dictionary<int, Opiskelija>();
            string syöte;

            while (true)
            {
                Console.WriteLine("------------------");
                Console.WriteLine("Mitä haluat tehdä?");
                Console.WriteLine("1. lisää - Lisää opiskelijan kokelma");
                Console.WriteLine("2. poista - Poistaa opiskelijan kokoelmasta");
                Console.WriteLine("3. tulosta - Tulostaa opiskelija kokoelman");
                Console.WriteLine("4. poistu - Poistuu sovelluksesta");

                syöte = Console.ReadLine();

                switch (syöte)
                {
                  case "lisää":
                        LisääOpiskelija(opiskelijat);
                        break;
                  case "poista":
                        PoistaOpiskelija(opiskelijat);
                        break;
                  case "tulosta":
                        TulostaOpiskelija(opiskelijat);
                        break;
                  case "poistu":
                        return;
                    default:
                        break;
                    
                }
            }
        }
        static void LisääOpiskelija(Dictionary<int, Opiskelija> opiskelijat)
        {
            string syöte;
            Opiskelija uusiopiskelija = new Opiskelija();

            while (true)
            {
                Console.WriteLine("Anna uudelle opiskelijalle tiedot: ");
                Console.WriteLine("Etunimi: ");
                uusiopiskelija.Etunimi = Console.ReadLine();
                Console.WriteLine("Sukunimi: ");
                uusiopiskelija.Sukunimi = Console.ReadLine();
                Console.WriteLine("Ryhmätunnus");
                uusiopiskelija.RyhmäTunnus = Console.ReadLine();
                Console.WriteLine("OpiskelijaID");
                uusiopiskelija.OpiskelijaNumero = Convert.ToInt32(Console.ReadLine());

                if (opiskelijat.ContainsKey(uusiopiskelija.OpiskelijaNumero))
                {
                    Console.WriteLine("Opiskelija sanakirjassa on opiskelija samalla ID:llä");
                    continue;

                }
                else
                {
                    opiskelijat.Add(uusiopiskelija.OpiskelijaNumero, uusiopiskelija);
                }

            }

        }
        static void PoistaOpiskelija(Dictionary<int, Opiskelija> opiskelijat)
        {
            Console.WriteLine("Anna opiskelijan opiskelijaID jonka haluat poistaa: ");
            int syöte = Convert.ToInt32(Console.ReadLine());

            if (opiskelijat.ContainsKey(syöte))
            {
                Console.WriteLine("Opiskelija: " + opiskelijat[syöte].Etunimi + "poistettu");
            }
            else
            {
                Console.WriteLine("Opiskelija ID:llä " + syöte + " ei löydetty kokelmasta");
            }

            opiskelijat.Remove(syöte);

        }
        static void TulostaOpiskelija(Dictionary<int, Opiskelija> opiskelijat)
        {
            foreach (Opiskelija item in opiskelijat.Values)
            {
                item.TulostaTiedot();
            }
        }
    }
}
