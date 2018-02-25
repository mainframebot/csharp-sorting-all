using System;
using SortingLesson.Interfaces;

namespace SortingLesson.Algorithms
{
    internal class MergeSortBottomUpAlgorithm<T> : ISortingAlgorithm<T>
        where T : IComparable<T>
    {
        private T[] _aux;

        public void Sort(T[] items)
        {
            var count = items.Length;
            _aux = new T[count];

            for (var sz = 1; sz < count; sz = sz + sz)
            {
                for (var lo = 0; lo < count - sz; lo += sz + sz)
                {
                    Merge(items, lo, lo+sz-1, Math.Min(lo+sz+sz-1, count-1));
                }
            }
        }

        private void Merge(T[] items, int lo, int mid, int hi)
        {
            var i = lo;
            var j = mid + 1;

            for (var k = lo; k <= hi; k++)
                _aux[k] = items[k];

            for (var k = lo; k <= hi; k++)
            {
                if (i > mid)
                {
                    items[k] = _aux[j++];
                }
                else if (j > hi)
                {
                    items[k] = _aux[i++];
                }
                else if (Less(_aux[j], _aux[i]))
                {
                    items[k] = _aux[j++];
                }
                else
                {
                    items[k] = _aux[i++];
                }
            }
        }

        private static bool Less(T v, T w)
        {
            return v.CompareTo(w) < 0;
        }
    }
}
