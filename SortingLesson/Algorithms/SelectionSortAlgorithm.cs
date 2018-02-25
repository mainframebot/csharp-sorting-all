using System;
using SortingLesson.Interfaces;

namespace SortingLesson.Algorithms
{
    internal class SelectionSortAlgorithm<T> : ISortingAlgorithm<T>
        where T : IComparable<T>
    {
        public void Sort(T[] items)
        {
            var count = items.Length;

            for (var i = 0; i < count; i++)
            {
                var smallest = i;

                for (var j = i+1; j < count; j++)
                {
                    if (Less(items[j], items[smallest]))
                        smallest = j;
                }

                Swap(items, i, smallest);
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
