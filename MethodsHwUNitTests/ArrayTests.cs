using NUnit.Framework;
using MethodsHw;
using System;

namespace MethodsHwUNitTests
{
    public class ArrayTests
    {
        [TestCase(1, 1)]
        [TestCase(2, 12)]
        [TestCase(3, 14)]
        [TestCase(4, 0)]
        public void FindMinEllementArrayTest(int arrayMockNumb, int expected)
        {
            int[] ar = GetArrayMock(arrayMockNumb);
            int actual = ArraysMethods.FindMinEllementArray(ar);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 9)]
        [TestCase(2, 95)]
        [TestCase(3, 98)]
        [TestCase(4, 67)]
        public void FindMaxEllementArrayTest(int arrayMockNumb, int expected)
        {
            int[] ar = GetArrayMock(arrayMockNumb);
            int actual = ArraysMethods.FindMaxEllementArray(ar);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2)]
        [TestCase(2, 0)]
        [TestCase(3, 1)]
        [TestCase(4, 4)]
        public void FindIndexMinEllementArrayTest(int arrayMockNumb, int expected)
        {
            int[] ar = GetArrayMock(arrayMockNumb);
            int actual = ArraysMethods.FindIndexMinEllementArray(ar);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 3)]
        [TestCase(2, 9)]
        [TestCase(3, 8)]
        [TestCase(4, 2)]
        public void FindIndexMaxEllementArrayTest(int arrayMockNumb, int expected)
        {
            int[] ar = GetArrayMock(arrayMockNumb);
            int actual = ArraysMethods.FindIndexMaxEllementArray(ar);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 21)]
        [TestCase(2, 271)]
        [TestCase(3, 253)]
        [TestCase(4, 30)]
        public void SumEllementsOddIndexTest(int arrayMockNumb, int expected)
        {
            int[] ar = GetArrayMock(arrayMockNumb);
            int actual = ArraysMethods.SumEllementsOddIndex(ar);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] { 4, 7, 8, 9, 1, 5, 3 })]
        [TestCase(2, new int[] { 95, 84, 73, 62, 51, 47, 35, 26, 17, 12 })]
        [TestCase(3, new int[] { 49, 98, 79, 86, 58, 45, 53, 42, 14, 20 })]
        [TestCase(4, new int[] { 1, 0, 25, 67, 4, 5 })]
        public void ReversArrayTest(int arrayMockNumb, int[] expected)
        {
            int[] ar = GetArrayMock(arrayMockNumb);
            int[] actual = ArraysMethods.ReversArray(ar);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 5)]
        [TestCase(2, 6)]
        [TestCase(3, 4)]
        [TestCase(4, 4)]
        public void FindCountOddElArrayTest(int arrayMockNumb, int expected)
        {
            int[] ar = GetArrayMock(arrayMockNumb);
            int actual = ArraysMethods.FindCountOddElArray(ar);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] { 8, 7, 4, 9, 3, 5, 1 })]
        [TestCase(2, new int[] { 51, 62, 73, 84, 95, 12, 17, 26, 35, 47 })]
        [TestCase(3, new int[] { 58, 86, 79, 98, 49, 20, 14, 42, 53, 45 })]
        [TestCase(4, new int[] { 25, 0, 1, 5, 4, 67 })]
        public void SwapHalfsArrayTest(int arrayMockNumb, int[] expected)
        {
            int[] ar = GetArrayMock(arrayMockNumb);
            int[] actual = ArraysMethods.SwapHalfsArray(ar);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] { 1, 3, 4, 5, 7, 8, 9 })]
        [TestCase(2, new int[] { 12, 17, 26, 35, 47, 51, 62, 73, 84, 95 })]
        [TestCase(3, new int[] { 14, 20, 42, 45, 49, 53, 58, 79, 86, 98 })]
        [TestCase(4, new int[] { 0, 1, 4, 5, 25, 67 })]
        public void SortArrayAscendingBubbleTest(int arrayMockNumb, int[] expected)
        {
            int[] ar = GetArrayMock(arrayMockNumb);
            int[] actual = ArraysMethods.SortArrayAscendingBubble(ar);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] { 9, 8, 7, 5, 4, 3, 1 })]
        [TestCase(2, new int[] { 95, 84, 73, 62, 51, 47, 35, 26, 17, 12 })]
        [TestCase(3, new int[] { 98, 86, 79, 58, 53, 49, 45, 42, 20, 14 })]
        [TestCase(4, new int[] { 67, 25, 5, 4, 1, 0 })]
        public void SortArrayDescendingSelectedTest(int arrayMockNumb, int[] expected)
        {
            int[] ar = GetArrayMock(arrayMockNumb);
            int[] actual = ArraysMethods.SortArrayDescendingSelected(ar);
            Assert.AreEqual(expected, actual);
        }

        public int[] GetArrayMock(int numb)
        {
            switch (numb)
            {
                case 1:
                    return new int[] { 3, 5, 1, 9, 8, 7, 4 };
                case 2:
                    return new int[] { 12, 17, 26, 35, 47, 51, 62, 73, 84, 95 };
                case 3:
                    return new int[] { 20, 14, 42, 53, 45, 58, 86, 79, 98, 49 };
                case 4:
                    return new int[] { 5, 4, 67, 25, 0, 1 };
                default:
                    throw new Exception("Test Error,nonexistent case.");
            }
        }
    }
}
