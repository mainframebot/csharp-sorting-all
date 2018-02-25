using System;

namespace SortingLesson.Interfaces
{
    internal interface ISorting
    {
        void Sort<T>(T[] items)
            where T : IComparable<T>;
    }
}
