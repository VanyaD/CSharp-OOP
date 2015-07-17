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
    public class Generic<T>
    {
        T item;
    }
    
    public static class ProductExtension
    {
        public static T Product<T>(this IEnumerable<T> arrayOfT) where T : struct
        {
            T result = (dynamic)1;

            
            foreach (T item in arrayOfT)
            {
                result = result * (dynamic)item;
            }
            return result;
        }
    }
}
