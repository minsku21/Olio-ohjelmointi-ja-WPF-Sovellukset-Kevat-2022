using System;

namespace Perintä
{
    class Program
    {
        static void Main(string[] args)
        {

            Opiskelija.KuinkaMontaOpiskelijaa();
            Henkilö.KuinkaMontaHenkilöä();

            Henkilö henkilö = new Henkilö("Matti", 20, 18765);
            Opiskelija opiskelija = new Opiskelija("Pekka", 18, 293847, 76789, "Careeria");

            henkilö.Tulostatiedot();
            opiskelija.Tulostatiedot();

            henkilö.Syö();
            opiskelija.Opiskele();

            Opiskelija.KuinkaMontaOpiskelijaa();
            Henkilö.KuinkaMontaHenkilöä();
        }
    }
}
