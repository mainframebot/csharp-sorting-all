using NUnit.Framework;
using SortingLesson;

namespace SortingLessonTests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void BubbleSortITesting()
        {
            int[] items = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };

            new BubbleSortI().Sort(items);
        }

        [Test]
        public void BubbleSortIITesting()
        {
            int[] items = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };

            new BubbleSortII().Sort(items);
        }

        [Test]
        public void SelectionSortTesting()
        {
            char[] items = {'S', 'O', 'R', 'T', 'E', 'X', 'A', 'M', 'P', 'L', 'E' };

            new SelectionSort().Sort(items);
        }

        [Test]
        public void InsertionSortTesting()
        {
            char[] items = { 'S', 'O', 'R', 'T', 'E', 'X', 'A', 'M', 'P', 'L', 'E' };

            new InsertionSort().Sort(items);
        }

        [Test]
        public void ShellSortTesting()
        {
            char[] items = { 'S', 'H', 'E', 'L', 'L', 'S', 'O', 'R', 'T', 'E', 'X', 'A', 'M', 'P', 'L', 'E' };

            new ShellSort().Sort(items);
        }

        [Test]
        public void MergeSortTopDownTesting()
        {
            char[] items = { 'M', 'E', 'R', 'G', 'E', 'S', 'O', 'R', 'T', 'E', 'X', 'A', 'M', 'P', 'L', 'E' };

            new MergeSortTopDown().Sort(items);
        }

        [Test]
        public void MergeSortBottomUpTesting()
        {
            char[] items = { 'M', 'E', 'R', 'G', 'E', 'S', 'O', 'R', 'T', 'E', 'X', 'A', 'M', 'P', 'L', 'E' };

            new MergeSortBottomUp().Sort(items);
        }

        [Test]
        public void QuickSort2WayTesting()
        {
            char[] items = { 'Q', 'U', 'I', 'C', 'K', 'S', 'O', 'R', 'T', 'E', 'X', 'A', 'M', 'P', 'L', 'E' };

            new QuickSort2Way().Sort(items);
        }

        [Test]
        public void QuickSort3WayTesting()
        {
            char[] items = { 'R', 'B', 'W', 'W', 'R', 'W', 'B', 'R', 'R', 'W', 'B', 'R' };

            new QuickSort3Way().Sort(items);
        }

        [Test]
        public void HeapSortTesting()
        {
            char[] items = { 'S', 'O', 'R', 'T', 'E', 'X', 'A', 'M', 'P', 'L', 'E' };

            new HeapSort().Sort(items);
        }
    }
}
