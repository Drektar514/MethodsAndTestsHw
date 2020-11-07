using NUnit.Framework;
using MethodsHw;

namespace MethodsHwUNitTests
{
    public class VariableTests
    {
        [TestCase(1, 2, 9)]
        [TestCase(2, 3, 19)]
        [TestCase(2, 1, -11)]
        [TestCase(20, 9, -16)]

        public void EquationSolutionTest(int a, int b, double expected)
        {
            double actual = Variable.EquationSolution(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 2)]
        [TestCase(5, 5)]
        [TestCase(15, 15)]
        [TestCase(27, 27)]

        public void EquationSolutionNegativeTest(int a, int b)
        {
            try
            {
                Variable.EquationSolution(a, b);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(1, 2, new int[] { 2, 1 })]
        [TestCase(156, 385, new int[] { 385, 156 })]
        [TestCase(25, 14, new int[] { 14, 25 })]
        [TestCase(1000, 0001, new int[] { 0001, 1000 })]

        public void SwapVariablesTest(int a, int b, int[] expected)
        {
            int[] actual = Variable.SwapVariables(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(6, 3, 2)]
        [TestCase(10, 2, 5)]
        [TestCase(100, 8, 12)]
        [TestCase(150, 3, 50)]

        public void DivisionTest(int a, int b, double expected)
        {
            double actual = Variable.Division(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(12, 0)]
        [TestCase(35, 0)]

        public void DivisionNegativeTest(int a, int b)
        {
            try
            {
                Variable.Division(a, b);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(10, 8, 2)]
        [TestCase(15, 5, 0)]
        [TestCase(27, 4, 3)]
        [TestCase(123, 90, 33)]
        public void RemainderOfDivisionTest(int a, int b, double expected)
        {
            double actual = Variable.RemainderOfDivision(a, b);
            Assert.AreEqual(expected, actual);

        }

        [TestCase(3, -6, 0, 2)]
        [TestCase(5, 15, 45, 6)]
        [TestCase(-8.5, 17, 0, 2)]
        [TestCase(0.2, -12, 4.8, 84)]

        public void EquationLinenearSolutionTest(double a, double b, double c, double expected)
        {
            double actual = Variable.EquationLinenearSolution(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0, 0)]
        [TestCase(0, 3, 6)]
        [TestCase(0, 15, 20)]
        public void EquationLinenearSolutionNegativeTest(double a, double b, double c)
        {
            try
            {
                Variable.EquationLinenearSolution(a, b, c);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(5.67, -3.12, -1.45, 4, new double[] { -0.62, 2.07 })]
        [TestCase(1.2, -3.45, 5.6, 8.2, new double[] { -0.56, 6.27 })]
        [TestCase(4.3, -8.5, -1.2, 4, new double[] { -0.41, 0.55 })]
        [TestCase(4, -1, 9, -3, new double[] { 2.4, -0.6 })]
        public void StraightLineEquationTest(double x1, double x2, double y1, double y2, double[] expected)
        {
            double pogreshnosty = 0.1;
            double[] actual = Variable.StraightLineEquation(x1, x2, y1, y2);
            Assert.AreEqual(expected[0], actual[0], pogreshnosty);
            Assert.AreEqual(expected[1], actual[1], pogreshnosty);
        }
        [TestCase(2.3, 2.3, -1.35, 4)]
        [TestCase(3, 3, 5.6, 8.3)]
        [TestCase(-1.2, -1.2, 3, 3)]
        public void StraightLineEquationNegativeTest(double x1, double x2, double y1, double y2)
        {
            try
            {
                Variable.StraightLineEquation(x1, x2, y1, y2);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}