using NUnit.Framework;
using MethodsHw;


namespace MethodsHwUNitTests
{
    public class TermsTests
    {
        [TestCase(8, 7, 15)]
        [TestCase(10, 9, 19)]
        [TestCase(2, 5, -3)]
        [TestCase(15, 20, -5)]
        [TestCase(10, 10, 100)]
        [TestCase(7, 7, 49)]
        public void ComparisonAAndBTest(int a, int b, int expected)
        {
            int actual = Terms.ComparisonAAndB(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0, "The point is at the center of coordinates")]
        [TestCase(1, 2, "Point is in the first quarter of coordinates")]
        [TestCase(7, 4, "Point is in the first quarter of coordinates")]
        [TestCase(-2, 8, "The point is in the second quarter of coordinates")]
        [TestCase(-5, 8, "The point is in the second quarter of coordinates")]
        [TestCase(-3, -3, "The point is in the third quarter of coordinates")]
        [TestCase(-2, -1, "The point is in the third quarter of coordinates")]
        [TestCase(2, -2, "The point is in the fourth quarter of coordinates")]
        [TestCase(6, -7, "The point is in the fourth quarter of coordinates")]
        [TestCase(0, -7, "The point does not belong to any of the quarters")]
        [TestCase(6, 0, "The point does not belong to any of the quarters")]
        public void FindQuarterCoordinatesTest(int x, int y, string expected)
        {
            string actual = Terms.FindQuarterCoordinates(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, 3, "1 2 3")]
        [TestCase(1, 3, 2, "1 2 3")]
        [TestCase(2, 1, 3, "1 2 3")]
        [TestCase(2, 3, 1, "1 2 3")]
        [TestCase(3, 2, 1, "1 2 3")]
        [TestCase(3, 1, 2, "1 2 3")]
        [TestCase(2, 1, 2, "1 2 2")]
        [TestCase(2, 0, 0, "0 0 2")]
        [TestCase(4, 4, 0, "0 4 4")]
        public void SortAscendingOrderTest(int a, int b, int c, string expected)
        {
            string actual = Terms.SortAscendingOrder(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, -2, -3, new double[] { 3, -1 })]
        [TestCase(4, 21, 5, new double[] { -0.25, -5 })]
        [TestCase(1, 6, 9, new double[] { -3 })]
        [TestCase(1, 12, 36, new double[] { -6 })]
        [TestCase(1, 2, 17, new double[] { })]
        [TestCase(3, 1, 2, new double[] { })]
        public void SolvingQuadraticEquationTest(double a, double b, double c, double[] expected)
        {
            double[] actual = Terms.SolvingQuadraticEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new double[] { 3, -1 }, "Equation roots - 3, -1.")]
        [TestCase(new double[] { 0.25, -5 }, "Equation roots - 0,25, -5.")]
        [TestCase(new double[] { 5 }, "Equation root - 5.")]
        [TestCase(new double[] { 0 }, "Equation root - 0.")]
        [TestCase(new double[] { }, "Equation has no roots")]
        public void ShowAnswerQuadraticEquationTest(double[] result, string expected)
        {
            string actual = Terms.ShowAnswerQuadraticEquation(result);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, "Десять")]
        [TestCase(15, "Пятнадцать")]
        [TestCase(23, "Двадцать три")]
        [TestCase(47, "Сорок семь")]
        [TestCase(99, "Девяносто девять")]
        public void WriteUserNumberTest(int number, string expexted)
        {
            string actual = Terms.WriteUserNumber(number);
            Assert.AreEqual(expexted, actual);
        }
    }
}
