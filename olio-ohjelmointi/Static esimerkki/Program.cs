using System;

namespace Static_esimerkki
{
    class Program
    {
        static void Main(string[] args)
        {
            
            float km = 45f;
            float mailit = Muuntaja.KmToMiles(km);

            Console.WriteLine(km + " kilometrejä on yhtä kuin" + mailit + " mailia");
        }
    }
}
