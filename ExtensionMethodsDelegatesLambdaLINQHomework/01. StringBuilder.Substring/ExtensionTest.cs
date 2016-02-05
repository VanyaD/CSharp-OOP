using System;
using System.Text;

namespace _01.Str.Substring
{
    class Program
    {
        static void Main()
        {
            StringBuilder test = new StringBuilder();
            test.Append("Vanya Karaasenova");
            StringBuilder result = new StringBuilder();
            result = test.Substring(6, 3);
            Console.WriteLine(result);           
        }
    }
}
