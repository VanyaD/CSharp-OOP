using System;
namespace _03.AnimalHierarchy
{
    public class Cat : Animals, ISound
    {
        public Cat(string name) : base(name)
        {
        }

        public Cat(string name, int age) : base(name, age)
        {
        }
        public override void SaySomething()
        {
            base.SaySomething();
            Console.WriteLine("Miau, miau");
        }
    }
}
