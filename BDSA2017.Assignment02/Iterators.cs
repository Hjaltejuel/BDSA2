using System;
using System.Collections.Generic;

namespace BDSA2017.Assignment02
{
    public static class Helpers
    {
        public static IEnumerable<T> Flatten<T>(IEnumerable<IEnumerable<T>> items)
        {
            foreach (IEnumerable<T> i in items)
            {
                foreach (T k in i)
                {
                    yield return k;
                }
            }
        }

        public static IEnumerable<T> Filter<T>(IEnumerable<T> items, Predicate<T> predicate)
        {
            foreach (T i in items)
            {
                if (predicate(i)) { yield return i; }
            }
        }
    }


}
