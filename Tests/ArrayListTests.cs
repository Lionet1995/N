using HomeworkArrayList;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class ArrayListTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new int[] { 11, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 11)]
        [TestCase(new int[] { 16, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 16)]

        public void AddVal_Test(int[] expected, int val)
        {
            ArrayList list = new ArrayList();
            list.Add(val);
            int[] actual = list.GetArray();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 16, 13 }, new int[] { 16, 13, 120, 0, 0, 0, 0, 0, 0, 0 }, 120)]
        public void AddVal_Test2(int[] enter, int[] expected, int val)
        {
            ArrayList list = new ArrayList();
            list.AddAll(enter);
            list.Add(val);
            int[] actual = list.GetArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0, 0, 0, 15, 0, 0, 0, 0, 0, 0 }, 15, 3)]
        [TestCase(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 9, 0 }, 9, 8)]

        public void AddIdx_Test(int[] expected, int val, int index)
        {
            ArrayList list = new ArrayList();
            list.Add(index, val);
            int[] actual = list.GetArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 2, 77, new int[] { 1, 2, 77, 4, 5, 6, 7, 8, 9, 10 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 9, 88, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 88 })]

        public void Set_Test(int[] array, int index, int val, int[] expected)
        {
            ArrayList list = new ArrayList();
            list.AddAll(array);
            list.Set(index, val);
            int[] actual = list.GetArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 9, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 10, 0 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 2, 7, 8, 9, 10 }, 2, new int[] { 1, 3, 4, 5, 2, 7, 8, 9, 10, 0 })]

        public void RemoveVal_Test(int[] array, int val, int[] expected)
        {
            ArrayList list = new ArrayList();
            list.AddAll(array);
            list.Remove(val);
            int[] actual = list.GetArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 4)]
        [TestCase(new int[] { }, 0)]

        public void Size_Test(int[] array, int expected)
        {
            ArrayList list = new ArrayList();
            list.AddAll(array);
            int actual = list.Size();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 7, 12, 45, 100 }, 22, false)]
        [TestCase(new int[] { 7, 12, 45, 100 }, 7, true)]
        [TestCase(new int[] { 7, 12, 45, 100 }, 64, false)]

        public void Contains_Test(int[] array, int val, bool expected)
        {
            ArrayList list = new ArrayList();
            list.AddAll(array);
            bool actual = list.Contains(val);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 7, 12, 45, 100 }, 45, 2)]
        [TestCase(new int[] { 7, 12, 45, 100 }, 12, 1)]
        [TestCase(new int[] { 7, 12, 45, 100, 177, 189, 201 }, 201, 6)]

        public void IndexOf_Test(int[] array, int val, int expected)
        {
            ArrayList list = new ArrayList();
            list.AddAll(array);
            int actual = list.IndexOf(val);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 0, 0, 0, 0, 0 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 0, 0, 0, 0, 0, 0 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 })]

        public void EnlargeArray_Test(int[] array, int[] expected)
        {
            ArrayList list = new ArrayList();
            list.AddAll(array);
            int[] actual = list.GetArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 5, new int[] { 0, 0, 0, 0, 0, 6, 7, 8, 9, 10 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 2, new int[] { 0, 0, 3, 4, 5, 6, 7, 8, 9, 10 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 8, new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 9, 10 })]

        public void AddAll_Test(int[] array, int index, int[] expected)
        {
            ArrayList list = new ArrayList();
            list.AddAll(array, index);
            int[] actual = list.GetArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 3, 4)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 7, 8)]
        [TestCase(new int[] { 6, 1, 9, 14, 32, 17, 87, 90, 13, 12 }, 5, 17)]
        [TestCase(new int[] { 6, 1, 9, 14, 32, 17, 87, 90, 13, 12, 15, 18, 21 }, 11, 18)]

        public void Get_Test(int[] array, int index, int expected)
        {
            ArrayList list = new ArrayList();
            list.AddAll(array);
            int actual = list.Get(index);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 3, new int[] { 1, 2, 4, 5, 6, 7, 8, 9, 10, 0 })]
        [TestCase(new int[] { 4, 2, 9, 1, 4, 0, 0, 0, 0, 0 }, 4, new int[] { 2, 9, 1, 0, 0, 0, 0, 0, 0, 0 })]
        [TestCase(new int[] { 1, 5, 4, 0, 0, 0, 0, 0, 0, 0 }, 5, new int[] { 1, 4, 0, 0, 0, 0, 0, 0, 0, 0 })]

        public void RemoveAll_Test(int[] array, int val, int[] expected)
        {
            ArrayList list = new ArrayList();
            list.AddAll(array);
            list.RemoveAll(val);
            int[] actual = list.GetArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 }, 1, new int[] { 10, 30, 40, 50, 60, 70, 80, 90, 100, 0 })]
        [TestCase(new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 }, 9, new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 0 })]
        [TestCase(new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 }, 0, new int[] { 20, 30, 40, 50, 60, 70, 80, 90, 100, 0 })]

        public void RemoveIdx_Test(int[] array, int index, int[] expected)
        {
            ArrayList list = new ArrayList();
            list.AddAll(array);
            list.RemoveIdx(index);
            int[] actual = list.GetArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 8, 10 }, 8, new int[] { 7, 8 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 2, new int[] { 1 })]
        [TestCase(new int[] { 90, 48, 32, 12, 57, 43, 55, 83, 67, 5 }, 333, new int[] { })]

        public void Search_Test(int[] array, int val, int[] expected)
        {
            ArrayList list = new ArrayList();
            list.AddAll(array);
            int[] actual = list.Search(val);
            Assert.AreEqual(expected, actual);
        }

    }
}