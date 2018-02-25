using System;
using SortingLesson.Interfaces;

namespace SortingLesson.Algorithms
{
    public class QuickSort3WayAlgorithm<T> : ISortingAlgorithm<T>
        where T : IComparable<T>
    {
        private static Random _random = new Random();

        public void Sort(T[] items)
        {
            Shuffle(items);

            Sort(items, 0, items.Length - 1);
        }

        private void Sort(T[] items, int lo, int hi)
        {
            if (hi <= lo)
                return;

            var lt = lo;
            var eq = lo + 1;
            var gt = hi;

            var v = items[lo];

            while (eq <= gt)
            {
                var cmp = items[eq].CompareTo(v);

                if (cmp < 0)
                {
                    Swap(items, lt++, eq++);
                }
                else if (cmp > 0)
                {
                    Swap(items, eq, gt--);
                }
                else
                {
                    eq++;
                }
            }

            Sort(items, lo, lt - 1);
            Sort(items, gt + 1, hi);
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
