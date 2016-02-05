using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IEnumerableExtensions
{
    class Tests
    {
        static void Main()
        {
            int[] tests = new int[3];

            for (int i = 0; i < tests.Length; i++)
            {
                tests[i] = i + 5;
                Console.WriteLine(tests[i]);
            }

            Console.WriteLine(tests.Sum());
            Console.WriteLine(tests.Product());
        }
    }
}
