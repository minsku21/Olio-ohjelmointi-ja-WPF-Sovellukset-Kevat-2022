using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_10
{
    class Animal
    {
        public string nimi;
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes sound");
        }
    }
}
