using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_10
{
    class Varis : Animal, ICanFly
    {
        public float WingZize { get; set; }

        public Varis(float wingZise)
        {
            WingZize = wingZise;
        }

        public void Fly()
        {
            Console.WriteLine("Varis lentää. Variksen siipien koko on " + WingZize);
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("Kwaaak Kwaak");
        }
    }
}
