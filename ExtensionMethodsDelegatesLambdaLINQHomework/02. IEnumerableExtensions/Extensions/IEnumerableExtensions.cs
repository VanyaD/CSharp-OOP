using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Problem 2. IEnumerable extensions
// • Implement a set of extension methods for  IEnumerable<T>  that implement 
//the following group functions: sum, product, min, max, average.

namespace _02.IEnumerableExtensions
{
    public static class IEnumerableExtensions
    {
        public static T SumIt<T>(this IEnumerable<T> arrayOfT) where T : struct
        {
            T result = new T();

            foreach (T item in arrayOfT)
            {
                result = (dynamic)result + item;
            }           
            return result;
        }
    }
}
