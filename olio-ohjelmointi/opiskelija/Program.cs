using System;

namespace opiskelija
{
    class Program
    {
        static void Main(string[] args)
        {
            Opiskelija opiskelija1 = new Opiskelija("Teija", "1234456", 0);

            opiskelija1.MuokkaaOpintopisteitä(7);
            
            opiskelija1.Tulosdata();
        }
    }
}
