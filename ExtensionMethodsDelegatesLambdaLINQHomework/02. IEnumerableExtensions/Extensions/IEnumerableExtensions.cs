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
        public static T Sum<T>(this IEnumerable<T> arrayOfT) where T : struct
        {
            T result = new T();

            foreach (T item in arrayOfT)
            {
                result = (dynamic)result + item;
            }

            return result;
        }

        public static T Min<T>(this IEnumerable<T> collection) where T : IConvertible, IComparable
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("Theere are no elements in the collection!");
            }

            T min = collection.First();
            foreach (var element in collection)
            {
                if (element.CompareTo(min) < 0)
                {
                    min = element;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection) where T : IConvertible, IComparable
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("There are no elements in the collection!");
            }

            T max = collection.First();
            foreach (var element in collection)
            {
                if (element.CompareTo(max) > 0)
                {

                    max = element;
                }
            }

            return max;
        }

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
