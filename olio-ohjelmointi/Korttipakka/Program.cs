﻿using System;
using System.Collections.Generic;

namespace Korttipakka
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> pakka = new List<string>();

            for (int i = 0; i < 13; i++)
            {
                pakka.Add("Pata - " + (i + 1));
                pakka.Add("Hertta - " + (i + 1));
                pakka.Add("Risti - " + (i + 1));
                pakka.Add("Ruutu - " + (i + 1));

            }
        }
    }
}
