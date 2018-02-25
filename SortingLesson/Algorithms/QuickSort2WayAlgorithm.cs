using System;
using SortingLesson.Interfaces;

namespace SortingLesson.Algorithms
{
    public class QuickSort2WayAlgorithm<T> : ISortingAlgorithm<T>
        where T : IComparable<T>
    {
        private static Random _random = new Random();

        public void Sort(T[] items)
        {
            Shuffle(items);

            Sort(items, 0, items.Length-1);
        }

        private void Sort(T[] items, int lo, int hi)
        {
            if (hi <= lo)
                return;

            var j = Partition(items, lo, hi);

            Sort(items, lo, j-1);
            Sort(items, j+1, hi);
        }

        private int Partition(T[] items, int lo, int hi)
        {
            var i = lo;
            var j = hi + 1;

            var v = items[lo];

            while (true)
            {
                while (Less(items[++i], v))
                {
                    if (i == hi)
                        break;
                }

                while (Less(v, items[--j]))
                {
                    if (j == lo)
                        break;
                }

                if (i >= j)
                    break;

                Swap(items, i, j);
            }

            Swap(items, lo, j);
            return j;
        }

        // Fisher-Yates Shuffle
        // http://www.dotnetperls.com/fisher-yates-shuffle
        private static void Shuffle(T[] items)
        {
            var count = items.Length;
            for (var i = 0; i < count; i++)
            {
                var r = i + (int)(_random.NextDouble() * (count - i));

                T t = items[r];
                items[r] = items[i];
                items[i] = t;
            }
        }

        private static bool Less(T v, T w)
        {
            return v.CompareTo(w) < 0;
        }

        private static void Swap(T[] items, int i, int j)
        {
            var swap = items[i];
            items[i] = items[j];
            items[j] = swap;
        }
    }
}
