using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog("Mike", 5, "male");
            Dog myDog2 = new Dog("Frank", 12, "male");
            Frog myFrog = new Frog("Jaba", 12, "female");
            Kitten myKitten = new Kitten("Kitty", 10);
            Tomcat myTomcat = new Tomcat("Gosho", 5);
            Cat myCat = new Cat("Pepi", 8);

            myDog.SaySomething();
            myCat.SaySomething();
            myFrog.SaySomething();
            myKitten.SaySomething();
            myTomcat.SaySomething();

            List<Animals> listOfAnimals = new List<Animals>();
            listOfAnimals.Add(myDog);
            listOfAnimals.Add(myDog2);

            //Console.WriteLine(Dog.CalculateAverageAge(listOfAnimals));
            double result = Dog.CalculateAverageAge(listOfAnimals);
            Console.WriteLine(result);



        }
    }
}
