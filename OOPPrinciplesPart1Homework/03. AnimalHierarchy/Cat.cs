using System;
namespace _03.AnimalHierarchy
{
    public abstract class Cat : Animal, ISound
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
