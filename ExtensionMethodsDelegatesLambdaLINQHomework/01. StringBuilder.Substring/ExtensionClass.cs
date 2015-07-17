using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Problem 1. StringBuilder.Substring
// • Implement an extension method  Substring(int index, int length) for the class  
// StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String .

namespace _01.Str.Substring
{
    public static class ExtensionClass
    {
        public static StringBuilder Substring(this StringBuilder str, int index, int length)
        {
            StringBuilder result = new StringBuilder();
            string temp = str.ToString();
            string stringRes = temp.Substring(index, length);
            result.Append(stringRes);

            return result;
        }
    }
}
