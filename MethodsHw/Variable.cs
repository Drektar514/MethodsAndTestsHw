using System;

namespace MethodsHw
{
    static public class Variable
    {
        static public int CreateIntVariable()
        {
            int a;
            Console.Write("Enter number - ");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Input Error. Enter integer number - ");
            }
            return a;
        }
        static public double CreateDoubleVariable()
        {
            double a;
            Console.Write("Enter number - ");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Input Error. Enter number - ");
            }
            return a;
        }
        static public int EquationSolution(int a, int b)
        {
            if (a == b)
            {
                throw new Exception("b can't be equal to 0.");
            }
            int result = (5 * a + b * b) / (b - a);
            return result;
        }
        static public int[] SwapVariables(int a, int b)
        {
            int c = a;
            a = b;
            b = c;
            int[] swapVariable = new int[] { a, b };
            return swapVariable;
        }
        static public int Division(int a, int b)
        {
            if (b == 0)
            {
                throw new Exception("b can't be equal to 0.");
            }
            int result = a / b;
            return result;
        }
        static public int RemainderOfDivision(int a, int b)
        {
            int result = a % b;
            return result;
        }
        static public double EquationLinenearSolution(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new Exception("a can't be equal to 0.");
            }
            double x = (c - b) / a;
            return x;
        }
        static public double[] StraightLineEquation(double x1, double x2, double y1, double y2)
        {
            if (x1 == x2)
            {
                throw new Exception("x1 can't be equal to x2.");
            }
            double k = (y1 - y2) / (x1 - x2);
            double b = y2 - k * x2;
            double[] values = new double[] { k, b };
            return values;
        }
    }
}
