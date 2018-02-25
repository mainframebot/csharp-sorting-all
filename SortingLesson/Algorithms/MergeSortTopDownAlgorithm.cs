using System;
using SortingLesson.Interfaces;

namespace SortingLesson.Algorithms
{
    internal class MergeSortTopDownAlgorithm<T> : ISortingAlgorithm<T>
        where T : IComparable<T>
    {
        private T[] _aux;

        public void Sort(T[] items)
        {
            _aux = new T[items.Length];
            Sort(items, 0, items.Length-1);
        }

        private void Sort(T[] items, int lo, int hi)
        {
            if (hi <= lo)
                return;

            var mid = (lo + hi) / 2;

            Sort(items, lo, mid);
            Sort(items, mid+1, hi);

            Merge(items, lo, mid, hi);
        }

        private void Merge(T[] items,int lo, int mid, int hi)
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
