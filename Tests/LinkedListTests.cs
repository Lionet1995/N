using NUnit.Framework;
using System.Collections;
using System;
using System.Text;
using System.Linq;
using LinkedList1;

namespace LinkedList1.Tests
{
    [TestFixture]
    public class LinkedListTests
    {
        [TestCase(new int[] { 10, 11, 12, 13 }, new int[] { 13, 12, 11, 10 })]
        [TestCase(new int[] { 10, 11, 12, 13, 24 }, new int[] { 24, 13, 12, 11, 10 })]
        public void Reverse1Test(int[] arr, int[] expected)
        {
            LinkedList list = new LinkedList(arr);
            list.Reverse();
            int[] actualArr = list.ToArray();
            Assert.AreEqual(expected, actualArr);
        }


        [TestCase(0, 5, new int[] { 10, 11, 12, 13 }, new int[] { 10, 5, 11, 12, 13 })]
        [TestCase(1, 4, new int[] { 10, 11, 12, 13, 24 }, new int[] { 10, 4, 11, 12, 13, 24 })]
        public void AddAtTest(int index, int value, int[] arr, int[] expected)
        {
            LinkedList list = new LinkedList(arr);
            list.AddAt(index, value);
            int[] actualArr = list.ToArray();
            Assert.AreEqual(expected, actualArr);
        }

        [TestCase(0, new int[] { 10, 11, 12, 13 }, new int[] { 12, 77 }, new int[] { 10, 77, 12, 11, 12, 13 })]
        [TestCase(1, new int[] { 18, 60, 13, 70 }, new int[] { 100, 100, 100 }, new int[] { 18, 100, 100, 100, 60, 13, 70 })]
        public void AddAt1Test(int index, int[] arr, int[] vals, int[] expected)
        {
            LinkedList list = new LinkedList(arr);
            list.AddAt(index, vals);
            int[] actualArr = list.ToArray();
            Assert.AreEqual(expected, actualArr);
        }

        [TestCase(12, new int[] { 10, 11, 12, 13 }, new int[] { 12, 10, 11, 12, 13 })]
        [TestCase(1, new int[] { 10, 11, 12, 13, 24 }, new int[] { 1, 10, 11, 12, 13, 24 })]
        public void AddFirstTest(int value, int[] enter, int[] expected)
        {
            LinkedList list = new LinkedList(enter);
            list.AddFirst(value);
            int[] actualArr = list.ToArray();
            Assert.AreEqual(expected, actualArr);
        }

        [TestCase(new int[] { 11, 22, 33, 44, 55, 66, 77 }, 0, 111, new int[] { 111, 22, 33, 44, 55, 66, 77 })]
        [TestCase(new int[] { 17, 18, 19, 20 }, 3, 1, new int[] { 17, 18, 19, 1 })]
        public void SetTest(int[] enter, int index, int value, int[] expected)
        {
            LinkedList list = new LinkedList(enter);
            list.Set(index, value);
            int[] actualArr = list.ToArray();
            Assert.AreEqual(expected, actualArr);
        }

        [TestCase(new int[] { 11, 22, 33, 44, 55, 66, 77 }, new int[] { 22, 33, 44, 55, 66, 77 })]
        [TestCase(new int[] { 17, 18, 19, 20 }, new int[] { 18, 19, 20 })]
        public void RemoveFirstTest(int[] enter, int[] expected)
        {
            LinkedList list = new LinkedList(enter);
            list.RemoveFirst();
            int[] actualArr = list.ToArray();
            Assert.AreEqual(expected, actualArr);
        }

        [TestCase(new int[] { 11, 22, 33, 44, 55, 66, 77 }, new int[] { 11, 22, 33, 44, 55, 66 })]
        [TestCase(new int[] { 17, 18, 19, 20 }, new int[] { 17, 18, 19 })]
        public void RemoveLastTest(int[] enter, int[] expected)
        {
            LinkedList list = new LinkedList(enter);
            list.RemoveLast();
            int[] actualArr = list.ToArray();
            Assert.AreEqual(expected, actualArr);
        }

        [TestCase(1, new int[] { 11, 22, 33, 44, 55, 66, 77 }, new int[] { 11, 33, 44, 55, 66, 77 })]
        [TestCase(0, new int[] { 17, 18, 19, 20 }, new int[] { 18, 19, 20 })]
        public void RemoveAtTest(int index, int[] enter, int[] expected)
        {
            LinkedList list = new LinkedList(enter);
            list.RemoveAt(index);
            int[] actualArr = list.ToArray();
            Assert.AreEqual(expected, actualArr);
        }

        [TestCase(5, new int[] { 11, 22, 33, 44, 55, 66, 77 }, new int[] { 11, 22, 33, 44, 55, 66, 77, 5 })]
        [TestCase(10, new int[] { 17, 18, 19, 20 }, new int[] { 17, 18, 19, 20, 10 })]
        public void AddLastTest(int value, int[] enter, int[] expected)
        {
            LinkedList list = new LinkedList(enter);
            list.AddLast(value);
            int[] actualArr = list.ToArray();
            Assert.AreEqual(expected, actualArr);
        }

        [TestCase(new int[] { 11, 22, 33, 44, 55, 66, 77 }, new int[] { 90, 5 }, new int[] { 11, 22, 33, 44, 55, 66, 77, 90, 5 })]
        [TestCase(new int[] { 17, 18, 19, 20 }, new int[] {80, 10}, new int[] { 17, 18, 19, 20, 80, 10 })]
        public void AddLast1Test(int[] enter, int[] plus, int[] expected)
        {
            LinkedList list = new LinkedList(enter);
            list.AddLast(plus);
            int[] actualArr = list.ToArray();
            Assert.AreEqual(expected, actualArr);
        }
    }
}