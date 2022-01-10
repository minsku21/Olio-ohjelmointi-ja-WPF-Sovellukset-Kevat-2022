using System;

namespace Albumitehtävä
{
    class Program
    {
        static void Main(string[] args)
        {
            Albumi albumi = new Albumi("Night Club","Scary world","Goth pop, Synth-pop, darkwave, electronica","8,85e");

            albumi.LisääKappale(new Kappale("Beware!", "1:24"));
            albumi.LisääKappale(new Kappale("Scary World", "3:10"));
            albumi.LisääKappale(new Kappale("Schizophrenic", "3:07"));
            albumi.LisääKappale(new Kappale("your Addiction", "3:31"));
            albumi.LisääKappale(new Kappale("Blood On your Blade", "3:07"));
            albumi.LisääKappale(new Kappale("Candy Coated Suicide", "3:30"));
            albumi.LisääKappale(new Kappale("Therapy (Get High)", "2:48"));
            albumi.LisääKappale(new Kappale("Imaginary Friends", "3:10"));
            albumi.LisääKappale(new Kappale("Vampires", "3:33"));
            albumi.LisääKappale(new Kappale("Survive", "4:32"));




        }
    }
}
