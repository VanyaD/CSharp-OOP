using System;

namespace _03.AnimalHierarchy
{
    public class Frog : Animals, ISound
    {
        public Frog(string name) : base(name)
        {
        }

        public Frog(string name, int age) : base(name, age)
        {
        }

        public Frog(string name, int age, string sex)
            : base(name, age, sex)
        {
        }

        public Frog(string name, string sex)
            : base(name)
        {
        }

        public override void SaySomething()
        {
            base.SaySomething();
            Console.WriteLine("Kva, kva");
        }
    }
}
