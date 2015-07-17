using System;
using System.Collections.Generic;

namespace _03.AnimalHierarchy
{
    public class Dog : Animals, ISound
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
            : base(name)
        {
        }

        public override void SaySomething()
        {
            base.SaySomething();
            Console.WriteLine("Bau, bau");        
        }

        public static double CalculateAverageAge(IEnumerable<Animals> listOfAnimals)
        {
            double averageAge = 0.0;
            double sumOfAllAges = 0;
            int count = 0;

            foreach (Dog dog in listOfAnimals)
            {
                sumOfAllAges += dog.Age;
                count++;
            }
            averageAge = sumOfAllAges / count;

            return averageAge;
        }
    }
}
