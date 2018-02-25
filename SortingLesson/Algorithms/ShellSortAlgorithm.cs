using System;
using SortingLesson.Interfaces;

namespace SortingLesson.Algorithms
{
    internal class ShellSortAlgorithm<T> : ISortingAlgorithm<T>
        where T : IComparable<T>
    {
        public void Sort(T[] items)
        {
            var count = items.Length;

            var h = 1;
            while (h < count/3)
                h = 3*h + 1;

            while (h >= 1)
            {
                for (var i = h; i < count; i++)
                {
                    for(var j = i; j >= h && Less(items[j], items[j-h]); j -=h)
                        Swap(items, j, j-h);
                }

                h /= 3;
            }
        }

        private static bool Less(T v, T w)
        {
            return v.CompareTo(w) < 0;
        }

        private static void Swap(T[] items, int i, int j)
        {
            var swap = items[i];
            items[i] = items[j];
            items[j] = swap;
        }
    }
}
