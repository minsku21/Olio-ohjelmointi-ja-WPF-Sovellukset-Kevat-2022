using System;
using System.Collections.Generic;

namespace Kokoelmat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();
            lista.Add("Pekka");
            lista.Add("Matti");
            lista.Add("Juha");

            lista.Remove("Matti");

            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------PINO-----");
            Stack<string> pino = new Stack<string>();

            pino.Push("Kortti 1");
            pino.Push("Kortti 2");
            pino.Push("Kortti 3");

            Console.WriteLine("Pinossa on " + pino.Count +  " objektia");
            Console.WriteLine(pino.Peek());

            pino.Pop();

            Console.WriteLine("Pinossa on " + pino.Count + " objektia");
            Console.WriteLine(pino.Peek());

            Console.WriteLine("------JONO-----");

            Queue<string> jono = new Queue<string>();

            jono.Enqueue("Pekka");
            jono.Enqueue("Matti");
            jono.Enqueue("Juha");

            Console.WriteLine("Jonossa on " + jono.Count + " henkilöä");
            Console.WriteLine(jono.Peek() + " on ensimmäinen jonossa");

            Console.WriteLine("-----------SANAKIRJA---------");

            Dictionary<string, string> sanakirja = new Dictionary<string, string>();
            sanakirja.Add("1525-2627", "Matti");
            sanakirja.Add("6253-3526", "Pekka");

            Console.WriteLine("Sankirjassa on " + sanakirja.Count + " henkilöä");

            Console.WriteLine("Etsitään sanakirjasta avaimella 1836-8373 " + sanakirja["1525-2627"]);

            foreach (string avain in sanakirja.Keys)
            {
                Console.WriteLine("sankirjasta haettu avaimella: " + avain + ", value: " + sanakirja[avain]);
            }

            foreach (string henkilö in sanakirja.Values)
            {
                Console.WriteLine("sankirjasta haettu avaimella: " + henkilö);
            }


            Console.WriteLine("Etsitään sanakirjasta avaimella 6253-3526 " + sanakirja["6253-3526"]);

            sanakirja.Add("9438-2039", "juha");
        }
    }
}
