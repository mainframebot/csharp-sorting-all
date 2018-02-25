using System;
using SortingLesson.Algorithms;
using SortingLesson.Interfaces;

namespace SortingLesson
{
    public class BubbleSortII : ISorting
    {
        public void Sort<T>(T[] items) where T : IComparable<T>
        {
            new Sorting().Sort(new BubbleSortAlgorithmII<T>(), items);
        }
    }
}
