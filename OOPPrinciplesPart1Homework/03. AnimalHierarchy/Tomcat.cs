using System;

namespace _03.AnimalHierarchy
{
    public class Tomcat : Cat, ISound
    {
        public Tomcat(string name) : base(name)
        {
            this.Sex = "male";
        }

        public Tomcat(string name, int age) : base(name, age)
        {
            this.Sex = "male";
        }
    }
}
