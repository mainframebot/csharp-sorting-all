using System;
using SortingLesson.Interfaces;

namespace SortingLesson.Algorithms
{
    public class BubbleSortIAlgorithm<T> : ISortingAlgorithm<T> 
        where T : IComparable<T>
    {
        public void Sort(T[] items)
        {
            var count = items.Length;

            for (var i = 0; i < count; i++)
            {
                for (var j = 0; j < count - 1; j++)
                {
                    if(Less(items[j+1], items[j]))
                        Swap(items, j + 1, j);
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
