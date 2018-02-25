using System;
using SortingLesson.Algorithms;
using SortingLesson.Interfaces;

namespace SortingLesson
{
    public class QuickSort3Way : ISorting
    {
        public void Sort<T>(T[] items) where T : IComparable<T>
        {
            new Sorting().Sort(new QuickSort3WayAlgorithm<T>(), items);
        }
    }
}
