using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Problems_567_
{
    public static class GenericListMain
    {
        static void Main(string[] args)
        {
            GenericList<int> test = new GenericList<int>(10);

            // test the Add functionality
            for (int i = 0; i < 20; i++)
            {
                test.AddElement(i);
                Console.WriteLine(test[i] + " " + test.Count + " " + test.Capacity);
            }

            // test the Min and Max functionality
            Console.WriteLine(test.Min());
            Console.WriteLine(test.Max());
            
            // test ToString
            Console.WriteLine(test);
            Console.WriteLine(test.IndexOf(100));

            // test the Remove functionality
            test.RemoveElement(3);
            for (int i = 0; i < 19; i++)
            {
                Console.WriteLine(test[i] + " " + test.Count + " " + test.Capacity);
            }

            // test the Insert functionality
            test.InsertAt(5, 100);
            for (int i = 0; i < 19; i++)
            {
                Console.WriteLine(test[i] + " " + test.Count + " " + test.Capacity);
            }

            // test the ClearAll functionality
            test.ClearAll();
            for (int i = 0; i <= test.Count; i++)
            {
                Console.WriteLine(test[i] + " " + test.Count + " " + test.Capacity);
            }

            int res = test.IndexOf(4);
            Console.WriteLine(res);

            
        }
    }
}
