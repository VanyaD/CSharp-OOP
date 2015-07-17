using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Problem 6. Divisible by 7 and 3
// • Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
// Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.


namespace _06.DivisibleBy7And3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Enumerable.Range(1, 100).ToArray();

            Console.WriteLine("All numbers in the array:\n");
            foreach (var item in numbersArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Using Lambda:");

            int[] results = numbersArray.Where(res => (res % 3 == 0) && (res % 7 == 0)).ToArray();

            foreach (int result in results)
            {
                Console.WriteLine(result);
            }
            Console.WriteLine();
            Console.WriteLine("Using Linq:");
            var results2 =
                from number in numbersArray
                where (number % 3 == 0) && (number % 7 == 0)
                select number;

            foreach (int result in results2)
            {
                Console.WriteLine(result);
            }
        }
    }
}
