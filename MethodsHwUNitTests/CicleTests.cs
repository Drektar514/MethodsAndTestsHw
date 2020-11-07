using NUnit.Framework;
using MethodsHw;

namespace MethodsHwUNitTests
{
    public class CicleTests
    {
        [TestCase(2, 2, 4)]
        [TestCase(3, 3, 27)]
        [TestCase(5, 5, 3125)]
        [TestCase(7, 4, 2401)]

        public void RaiseToPowerTest(int a, int b, int expected)
        {
            int actual = Cicle.RaiseToPower(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(777, new int[] { 777 })]
        [TestCase(200, new int[] { 200, 400, 600, 800 })]
        [TestCase(965, new int[] { 965 })]
        [TestCase(150, new int[] { 150, 300, 450, 600, 750, 900 })]
        public void ShowAllNumbersFissileOnATest(int a, int[] expected)
        {
            int[] actual = Cicle.ShowAllNumbersFissileOnA(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 3)]
        [TestCase(50, 7)]
        [TestCase(-2, 0)]
        [TestCase(100, 9)]
        public void ShowCountNumberSquareBiggerATest(int a, int expected)
        {
            int actual = Cicle.ShowCountNumberSquareBiggerA(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(7, 1)]
        [TestCase(25, 5)]
        [TestCase(50, 25)]
        [TestCase(0, 0)]
        [TestCase(-20, 0)]
        public void ShowShowGreatestDivisorTest(int a, int expected)
        {
            int actual = Cicle.ShowGreatestDivisor(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(14, 21, 35)]
        [TestCase(21, 14, 35)]
        [TestCase(21, 21, 21)]
        [TestCase(10, 30, 63)]
        public void SumNumbersABDividedBy7Test(int a, int b, int expected)
        {
            int actual = Cicle.SumNumbersABDividedBy7(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-7, 0)]
        [TestCase(1, 0)]
        [TestCase(2, 1)]
        [TestCase(5, 5)]
        [TestCase(10, 55)]
        [TestCase(13, 233)]
        public void ShowNumberSeriesFibonacciTest(int a, int expected)
        {
            int actual = Cicle.ShowNumberSeriesFibonacci(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(150, 200, 50)]
        [TestCase(1000, 300, 100)]
        [TestCase(12, 36, 12)]
        [TestCase(100, 2, 2)]
        public void FindGCDTest(int a, int b, int expected)
        {
            int actual = Cicle.FindGCD(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(8, 2)]
        [TestCase(1, 1)]
        [TestCase(27, 3)]
        [TestCase(64, 4)]
        [TestCase(216, 6)]
        public void FindNumberFromCubeWithHalfDivisionTest(int a, int expected)
        {
            int actual = Cicle.FindNumberFromCubeWithHalfDivision(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(15, 2)]
        [TestCase(352, 2)]
        [TestCase(4567, 2)]
        [TestCase(3330, 3)]
        [TestCase(248, 0)]
        public void FindCountOddNumbersTest(int A, int expected)
        {
            int actual = Cicle.FindCountOddNumbers(A);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(7, 3)]
        [TestCase(1, 0)]
        [TestCase(53, 24)]
        [TestCase(15, 6)]
        public void ShowCountSumEvenGreatestObbTest(int A, int expected)
        {
            int actual = Cicle.ShowCountSumEvenGreatestObb(A);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(123, 456, "No")]
        [TestCase(12345, 67890, "No")]
        [TestCase(15973, 23946, "Yes")]
        [TestCase(22, 432, "Yes")]
        public void CompareByNumbersTest(int A, int B, string expected)
        {
            string actual = Cicle.CompareByNumbers(A, B);
            Assert.AreEqual(expected, actual);
        }
    }
}
