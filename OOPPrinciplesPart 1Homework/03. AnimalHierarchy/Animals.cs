using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.AnimalHierarchy
{
    public class Animals : ISound
    {           
        private string name;
        private int age;
        private string sex;
        //private IEnumerable<Animals> listOfAnimals;

        //public IEnumerable<Animals> ListOfAnimals
        //{
        //    get { return listOfAnimals; }
        //    set { listOfAnimals = value; }
        //}        

        public Animals(string name)
        {
            this.Name = name;
        }

        public Animals(string name, int age) : this(name)
        {
            this.Age = age;
        }

        public Animals(string name, int age, string sex)
            : this(name, age)
        {
            this.Sex = sex;
        }

        public Animals(string name, string sex)
            : this(name)
        {
            this.Sex = sex;
        }

        public string Sex
        {
            get { return sex; }
            protected set { sex = value; }
        }
        
        public int Age
        {
            get { return age; }
            protected set { age = value; }
        }
        
        public string Name
        {
            get { return name; }
            protected set { name = value; }
        }
        
        public virtual void SaySomething()
        {
            Console.Write("{0}: ", this.Name);
        }

        public static void CalculateAverageAge(List<Animals> listOfAnimals)
        {
            double averageAge = 0.0;
            int sumOfAllAges = 0;
            int count = 0;
            foreach (Animals animal in listOfAnimals)
            {
                sumOfAllAges += animal.Age;
                count++;
            }

            averageAge = sumOfAllAges / count;
        }
    }
}
