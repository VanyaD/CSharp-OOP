using System;
using System.Collections.Generic;

namespace _03.AnimalHierarchy
{
    public abstract class Animal : ISound
    {
        private static List<Animal> animals;

        private string name;
        private int age;
        private string sex;
        
        public Animal(string name)
        {
            this.Name = name;
            if (Animals == null)
            {
                Animals = new List<Animal>();
            }

            Animals.Add(this);
        }

        public Animal(string name, int age) : this(name)
        {
            this.Age = age;
        }

        public Animal(string name, int age, string sex)
            : this(name, age)
        {
            this.Sex = sex;
        }

        public Animal(string name, string sex)
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

        public static List<Animal> Animals
        {
            get { return animals; }
            set { animals = value; }
        }

        public virtual void SaySomething()
        {
            Console.Write("{0}: ", this.Name);
        }

        public static double CalculateAverageAge()
        {
            double averageAge = 0.0;
            int sumOfAllAges = 0;
            int count = 0;

            foreach (Animal animal in Animals)
            {
                sumOfAllAges += animal.Age;
                count++;
            }

            averageAge = (double)sumOfAllAges/count;

            return averageAge;
        }
    }
}
