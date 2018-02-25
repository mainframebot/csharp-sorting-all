using System;
using SortingLesson.Interfaces;

namespace SortingLesson
{
    internal class Sorting
    {
        public void Sort<T>(ISortingAlgorithm<T> algorithm, T[] items)
            where T : IComparable<T>
        {
            if(items == null)
                throw new ArgumentNullException();

            if(items.Length == 0)
                throw new ArgumentOutOfRangeException();

            algorithm.Sort(items);
        }
    }
}
