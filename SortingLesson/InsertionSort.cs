using System;
using SortingLesson.Algorithms;
using SortingLesson.Interfaces;

namespace SortingLesson
{
    public class InsertionSort : ISorting
    {
        public void Sort<T>(T[] items) where T : IComparable<T>
        {
            new Sorting().Sort(new InsertionSortAlgorithm<T>(), items);
        }
    }
}
