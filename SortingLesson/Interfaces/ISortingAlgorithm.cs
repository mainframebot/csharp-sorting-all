using System;

namespace SortingLesson.Interfaces
{
    internal interface ISortingAlgorithm<T> 
        where T : IComparable<T>
    {
        void Sort(T[] items);
    }
}
