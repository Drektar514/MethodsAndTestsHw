using NUnit.Framework;
using MethodsHw;
using System;

namespace MethodsHwUNitTests
{
    public class TwoDimensionalArrayTests
    {
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 4)]
        public void FlipMainDiagonalTest(int expectedMockNumber, int arrayMockNumb)
        {
            int[,] expected = GetExpectedMock(expectedMockNumber);
            int[,] ar = GetArrayMock(arrayMockNumb);
            int[,] actual = TwoDimensoinalArrayMethods.FlipMainDiagonal(ar);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 0)]
        [TestCase(4, 0)]
        public void FindMinElArrayTest(int arrayMockNumber, int expected)
        {
            int[,] ar = GetArrayMock(arrayMockNumber);
            int actual = TwoDimensoinalArrayMethods.FindMinElArray(ar);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 9)]
        [TestCase(2, 8)]
        [TestCase(3, 9)]
        [TestCase(4, 95)]
        public void FindMaxElArrayTest(int arrayMockNumber, int expected)
        {
            int[,] ar = GetArrayMock(arrayMockNumber);
            int actual = TwoDimensoinalArrayMethods.FindMaxElArray(ar);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] { 0, 0 })]
        [TestCase(2, new int[] { 1, 0 })]
        [TestCase(3, new int[] { 4, 1 })]
        [TestCase(4, new int[] { 2, 2 })]
        public void FindIndexMixElArrayTest(int arrayMockNumber, int[] expected)
        {
            int[,] ar = GetArrayMock(arrayMockNumber);
            int[] actual = TwoDimensoinalArrayMethods.FindIndexMinElArray(ar);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] { 2, 2 })]
        [TestCase(2, new int[] { 0, 3 })]
        [TestCase(3, new int[] { 4, 0 })]
        [TestCase(4, new int[] { 1, 1 })]
        public void FindIndexMaxElArrayTest(int arrayMockNumber, int[] expected)
        {
            int[,] ar = GetArrayMock(arrayMockNumber);
            int[] actual = TwoDimensoinalArrayMethods.FindIndexMaxElArray(ar);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        public void FindCountElBiggerNeighborsTest(int arrayMockNumber, int expected)
        {
            int[,] ar = GetArrayMock(arrayMockNumber);
            int actual = TwoDimensoinalArrayMethods.FindCountElBiggerNeighbors(ar);
            Assert.AreEqual(expected, actual);
        }
        public int[,] GetArrayMock(int numb)
        {
            switch (numb)
            {
                case 1:
                    return new int[,]
                    {
                       { 1, 2, 3 },
                       { 4, 5, 6 },
                       { 7, 8, 9 }
                    };
                case 2:
                    return new int[,]
                    {
                        {2,4,6,8 },
                        {1,3,5,7 }
                    };
                case 3:
                    return new int[,]
                    {
                        {1,2},
                        {3,4},
                        {5,6},
                        {7,8},
                        {9,0}
                    };
                case 4:
                    return new int[,]
                    {
                       { 15, 2, 33 },
                       { 4, 95, 26 },
                       { 47, 80, 0 }
                    };
                default:
                    throw new Exception("Test Error,nonexistent case.");
            }
        }
        public int[,] GetExpectedMock(int numb)
        {
            switch (numb)
            {
                case 1:
                    return new int[,]
                    {
                       { 1, 4, 7 },
                       { 2, 5, 8 },
                       { 3, 6, 9 }
                    };
                case 2:
                    return new int[,]
                    {
                        {2,1},
                        {4,3},
                        {6,5},
                        {8,7}
                    };
                case 3:
                    return new int[,]
                    {
                        {1,3,5,7,9},
                        {2,4,6,8,0}
                    };
                case 4:
                    return new int[,]
                    {
                       { 15, 4, 47 },
                       { 2, 95, 80 },
                       { 33, 26, 0 }
                    };
                default:
                    throw new Exception("Test Error,nonexistent case.");
            }
        }
    }
}
