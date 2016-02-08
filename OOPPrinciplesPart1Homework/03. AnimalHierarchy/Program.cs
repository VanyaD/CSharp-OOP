using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalHierarchy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dog myDog = new Dog("Mike", 5, "male");
            Dog myDog2 = new Dog("Frank", 12, "male");
            Frog myFrog = new Frog("Jaba", 12, "female");
            Kitten myKitten = new Kitten("Kitty", 10);
            Tomcat myTomcat = new Tomcat("Gosho", 5);

            myDog.SaySomething();
            myFrog.SaySomething();
            myKitten.SaySomething();
            myTomcat.SaySomething();

            double averageAge = Animal.CalculateAverageAge();
            Console.WriteLine(averageAge);
        }
    }
}
