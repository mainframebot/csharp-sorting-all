using System;
using SortingLesson.Interfaces;

namespace SortingLesson.Algorithms
{
    internal class BubbleSortAlgorithmII<T> : ISortingAlgorithm<T>
        where T : IComparable<T>
    {
        public void Sort(T[] items)
        {
            var count = items.Length;

            for (var i = 0; i < count; i++)
            {
                for (var j = count - 1; j > i; j--)
                {
                    if (Less(items[j], items[j - 1]))
                        Swap(items, j, j - 1);
                }
            }
        }

        private bool Less(T i, T j)
        {
            return i.CompareTo(j) < 0;
        }

        private void Swap(T[] items, int i, int j)
        {
            var temp = items[i];
            items[i] = items[j];
            items[j] = temp;
        }
    }
}
