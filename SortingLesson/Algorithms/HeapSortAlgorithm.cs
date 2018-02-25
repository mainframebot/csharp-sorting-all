using System;
using SortingLesson.Interfaces;

namespace SortingLesson.Algorithms
{
    internal class HeapSortAlgorithm<T> : ISortingAlgorithm<T>
        where T : IComparable<T>
    {
        public void Sort(T[] items)
        {
            var count = items.Length;

            for(var k = count/2; k >= 1; k--)
                Sink(items, k, count);

            while(count > 1)
            {
                Swap(items, 1, count--);
                Sink(items, 1, count);
            }
        }

        private void Sink(T[] items, int k, int count)
        {
            while (2*k <= count)
            {
                var j = 2*k;

                if (j < count && Less(items, j, j + 1))
                    j++;

                if (!Less(items, k, j))
                    break;

                Swap(items, k, j);

                k = j;
            }
        }


        private static bool Less(T[] items, int i, int j)
        {
            return items[i-1].CompareTo(items[j-1]) < 0;
        }

        private static void Swap(T[] items, int i, int j)
        {
            var swap = items[i-1];
            items[i-1] = items[j-1];
            items[j-1] = swap;
        }
    }
}
