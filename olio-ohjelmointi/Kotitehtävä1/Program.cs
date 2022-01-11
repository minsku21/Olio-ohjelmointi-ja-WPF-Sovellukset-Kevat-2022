using System;

namespace Kotitehtävä1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pomo.KuinkaMontaPomoa();
            Työntekijä.KuinkaMontaTyöntekijää();
            Henkilö.KuinkaMontaHenkilöä();

           Pomo pomo = new Pomo("Late","Careeria", 20, "Ford", 45);
            Työntekijä työntekijä = new Työntekijä("Pekka","Careeria", 34, 67);
            Pomo pomo2 = new Pomo("Late", "Careeria", 20, "Ford", 45);

            työntekijä.Tulostatiedot();
            pomo.Tulostatiedot();

            Pomo.KuinkaMontaPomoa();
            Työntekijä.KuinkaMontaTyöntekijää();
            Henkilö.KuinkaMontaHenkilöä();
        }
    }
}
