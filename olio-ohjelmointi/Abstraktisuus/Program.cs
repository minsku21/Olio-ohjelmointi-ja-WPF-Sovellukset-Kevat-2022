using System;

namespace Abstraktisuus
{
    class Program
    {
        static void Main(string[] args)
        {
            Opiskelija opiskelija = new Opiskelija();
            opiskelija.Nimi = "Tiitus";

            opiskelija.Puhu();

            Henkilö.KuinkaMonta();
        }
    }
}
