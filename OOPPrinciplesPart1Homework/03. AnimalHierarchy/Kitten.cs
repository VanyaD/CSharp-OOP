using System;

namespace _03.AnimalHierarchy
{
    public class Kitten : Cat, ISound
    {
        public Kitten(string name) : base(name)
        {
            this.Sex = "female";
        }

        public Kitten(string name, int age) : base(name, age)
        {
            this.Sex = "female";
        }
    }
}
