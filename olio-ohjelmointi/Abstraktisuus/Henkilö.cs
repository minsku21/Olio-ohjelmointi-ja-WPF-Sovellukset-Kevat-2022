﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraktisuus
{
    abstract class Henkilö
    {
        public abstract string Nimi { get; set; }

        public abstract void Puhu();

        public static int Instanssit =0;

        public Henkilö()
        {
            Instanssit++;
        }
        public static void KuinkaMonta()
        {
            Console.WriteLine("Henkilöä elossa: " + Instanssit);
        }
    }
}
