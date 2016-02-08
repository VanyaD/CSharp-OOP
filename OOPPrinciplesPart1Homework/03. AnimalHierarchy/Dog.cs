using System;
using System.Collections.Generic;

namespace _03.AnimalHierarchy
{
    public class Dog : Animal, ISound
    {
        public Dog(string name)
            : base(name)
        {
        }

        public Dog(string name, int age)
            : base(name, age)
        {
        }

        public Dog(string name, int age, string sex)
            : base(name, age, sex)
        {
        }

        public Dog(string name, string sex)
            : base(name, sex)
        {
        }

        public override void SaySomething()
        {
            base.SaySomething();
            Console.WriteLine("Bau, bau");        
        }
    }
}
