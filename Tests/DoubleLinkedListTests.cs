using NUnit.Framework;
using DoublelinkedList;

namespace Tests
{
    [TestFixture]
    public class DoubleLinkedListTests
    {

        [TestCase(12, new int[] { 10, 11, 12, 13 }, new int[] { 12, 10, 11, 12, 13 })]
        [TestCase(1, new int[] { 10, 11, 12, 13, 24 }, new int[] { 1, 10, 11, 12, 13, 24 })]
        public void AddFirstTest(int value, int[] enter, int[] expected)
        {
            DoubleLinkedList1 list = new DoubleLinkedList1(enter);
            list.AddFirst(value);
            int[] actualArr = list.ToArray();
            Assert.AreEqual(expected, actualArr);
        }

        [TestCase(new int[] { 10, 11, 12, 13 }, new int[] { 11, 44 }, new int[] { 44, 11, 10, 11, 12, 13 })]
        [TestCase(new int[] { 10, 11, 12, 13, 24 }, new int[] { 33, 900 }, new int[] { 900, 33, 10, 11, 12, 13, 24 })]
        public void AddFirstTest1(int[] enter, int[] plus, int[] expected)
        {
            DoubleLinkedList1 list = new DoubleLinkedList1(enter);
            list.AddFirst(plus);
            int[] actualArr = list.ToArray();
            Assert.AreEqual(expected, actualArr);
        }

        [TestCase(666, new int[] { 222, 333, 444, 555 }, new int[] { 222, 333, 444, 555, 666 })]
        [TestCase(777, new int[] { 222, 333, 444, 555, 666 }, new int[] { 222, 333, 444, 555, 666, 777 })]
        public void AddLastTest(int value, int[] enter, int[] expected)
        {
            DoubleLinkedList1 list = new DoubleLinkedList1(enter);
            list.AddLast(value);
            int[] actualArr = list.ToArray();
            Assert.AreEqual(expected, actualArr);
        }
        [TestCase(new int[] { 10, 11, 12, 13 }, new int[] { 11, 44 }, new int[] { 10, 11, 12, 13, 11, 44 })]
        [TestCase(new int[] { 10, 11, 12, 13, 24 }, new int[] { 33, 900 }, new int[] { 10, 11, 12, 13, 24, 33, 900 })]
        public void AddLastTest1(int[] enter, int[] plus, int[] expected)
        {
            DoubleLinkedList1 list = new DoubleLinkedList1(enter);
            list.AddLast(plus);
            int[] actualArr = list.ToArray();
            Assert.AreEqual(expected, actualArr);
        }

        [TestCase(new int[] { 10, 11, 12, 13 }, 13)]
        [TestCase(new int[] { 10, 11, 12, 13, 24 }, 24)]
        public void GetLastTest(int[] enter, int expected)
        {
            DoubleLinkedList1 list = new DoubleLinkedList1(enter);
            int actual = list.GetLast();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 15, new int[] { 10, 11, 12, 13 }, new int[] { 10, 15, 12, 13 })]
        [TestCase(3, 20, new int[] { 10, 11, 12, 13 }, new int[] { 10, 11, 12, 20 })]
        public void SetTest(int index, int value, int[] enter, int[] expected)
        {
            DoubleLinkedList1 list = new DoubleLinkedList1(enter);
            list.Set(index, value);
            int[] actualArr = list.ToArray();
            Assert.AreEqual(expected, actualArr);
        }

        [TestCase(1, new int[] { 10, 11, 12, 13 }, 11)]
        [TestCase(2, new int[] { 10, 11, 12, 13, 24 }, 12)]
        public void GetTest(int index, int[] enter, int expected)
        {
            DoubleLinkedList1 list = new DoubleLinkedList1(enter);
            int actual = list.Get(index);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 10, 11, 12, 13 }, new int[] { 13, 12, 11, 10 })]
        [TestCase(new int[] { 100, 200, 300, 700 }, new int[] { 700, 300, 200, 100 })]
        public void ReverseTest(int[] enter, int[] expected)
        {
            DoubleLinkedList1 list = new DoubleLinkedList1(enter);
            list.Reverse();
            int[] actualArr = list.ToArray();
            Assert.AreEqual(expected, actualArr);
        }

        [TestCase(new int[] { 10, 11, 12, 13 }, 10)]
        [TestCase(new int[] { 100, 200, 300, 700 }, 100)]
        public void GetFirstTest(int[] enter, int expected)
        {
            DoubleLinkedList1 list = new DoubleLinkedList1(enter);
            int actual = list.GetFirst();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 10, 11, 12, 13 }, 123, false)]
        [TestCase(new int[] { 100, 200, 300, 700 }, 700, true)]
        public void ContainsTest(int[] enter, int value, bool expected)
        {
            DoubleLinkedList1 list = new DoubleLinkedList1(enter);
            bool actual = list.Contains(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 10, 11, 12, 13 }, 1, -1)]
        [TestCase(new int[] { 100, 200, 300, 700 }, 200, 1)]
        public void IndexOfTest(int[] enter, int value, int expected)
        {
            DoubleLinkedList1 list = new DoubleLinkedList1(enter);
            int actual = list.IndexOf(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 10, 11, 12, 13 }, new int[] { 11, 12, 13 })]
        [TestCase(new int[] { 100, 200, 300, 700 }, new int[] { 200, 300, 700 })]
        public void RemoveFirstTest(int[] enter, int[] expected)
        {
            DoubleLinkedList1 list = new DoubleLinkedList1(enter);
            list.RemoveFirst();
            int[] actualArr = list.ToArray();
            Assert.AreEqual(expected, actualArr);
        }

        [TestCase(new int[] { 11, 22, 33, 44, 55, 66, 77 }, new int[] { 11, 22, 33, 44, 55, 66 })]
        [TestCase(new int[] { 17, 18, 19, 20 }, new int[] { 17, 18, 19 })]
        public void RemoveLastTest(int[] enter, int[] expected)
        {
            DoubleLinkedList1 list = new DoubleLinkedList1(enter);
            list.RemoveLast();
            int[] actualArr = list.ToArray();
            Assert.AreEqual(expected, actualArr);
        }

        [TestCase(2, new int[] { 10, 11, 12, 13 }, new int[] { 10, 11, 13 })]
        [TestCase(1, new int[] { 100, 200, 300, 700 }, new int[] { 100, 300, 700 })]
        [TestCase(3, new int[] { 100, 200, 300, 700 }, new int[] { 100, 200, 300 })]
        public void RemoveAtTest(int index, int[] enter, int[] expected)
        {
            DoubleLinkedList1 list = new DoubleLinkedList1(enter);
            list.RemoveAt(index);
            int[] actualArr = list.ToArray();
            Assert.AreEqual(expected, actualArr);
        }

        [TestCase(new int[] { 10, 11, 12, 13 }, 1, 5, new int[] { 10, 5, 11, 12, 13 })]
        [TestCase(new int[] { 100, 200, 300, 700 }, 2, 99, new int[] { 100, 200, 99, 300, 700 })]
        public void AddAtTest(int[] enter, int index, int value, int[] expected)
        {
            DoubleLinkedList1 list = new DoubleLinkedList1(enter);
            list.AddAt(index, value);
            int[] actualArr = list.ToArray();
            Assert.AreEqual(expected, actualArr);
        }

        [TestCase(0, new int[] { 10, 11, 12, 13 }, new int[] { 12, 77 }, new int[] { 10, 77, 12, 11, 12, 13 })]
        [TestCase(1, new int[] { 18, 60, 13, 70 }, new int[] { 100, 100, 100 }, new int[] { 18, 100, 100, 100, 60, 13, 70 })]
        public void AddAt1Test(int index, int[] arr, int[] vals, int[] expected)
        {
            DoubleLinkedList1 list = new DoubleLinkedList1(arr);
            list.AddAt(index, vals);
            int[] actualArr = list.ToArray();
            Assert.AreEqual(expected, actualArr);
        }
    }
}
