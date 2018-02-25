using System;
using SortingLesson.Interfaces;

namespace SortingLesson.Algorithms
{
    internal class InsertionSortAlgorithm<T> : ISortingAlgorithm<T>
        where T : IComparable<T>
    {
        public void Sort(T[] items)
        {
            var count = items.Length;

            for (var i = 0; i < count; i++)
            {
                for(var j = i; j > 0 && Less(items[j], items[j-1]); j--)
                    Swap(items, j, j-1);
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
