using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_10
{
    class Sorsa : Animal, ICanFly, ICanSwim
    {
        public float WingZize { get; set; }
        public float SwimSpeed { get; set; }

        public Sorsa(float wingZise, float swimSpeed)
        {
            WingZize = wingZise;
            SwimSpeed = swimSpeed;
        }

        public void Fly()
        {
            Console.WriteLine("Sorsa lentää. Sorsan siipien koko on " + WingZize);
        }

        public void Swim()
        {
            Console.WriteLine("Sorsa Ui. Sorsan uinti nopeus on " + SwimSpeed);
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("Quack Quack");
        }
    }
}
