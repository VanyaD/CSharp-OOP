using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Problem 4. Person class
// • Create a class  Person  with two fields – name and age. 
// Age can be left unspecified (may contain  null  value. Override  ToString()  to display 
// the information of a person and if age is not specified – to say so.
// • Write a program to test this functionality.

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person("Peter", 15);
            Console.WriteLine(firstPerson);

            Person secondPerson = new Person("Ivan");
            Console.WriteLine(secondPerson);
        }
    }
}
