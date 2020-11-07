using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsHw
{
    static public class Terms
    {
        static public int ComparisonAAndB(int a, int b)
        {
            int result;
            if (a > b)
            {
                result = a + b;
            }
            else if (a == b)
            {
                result = a * b;
            }
            else
            {
                result = a - b;
            }
            return result;
        }
        static public string FindQuarterCoordinates(int x, int y)
        {
            if (x > 0 && y > 0)
                return "Point is in the first quarter of coordinates";
            else if (x < 0 && y > 0)
                return "The point is in the second quarter of coordinates";
            else if (x < 0 && y < 0)
                return "The point is in the third quarter of coordinates";
            else if (x > 0 && y < 0)
                return "The point is in the fourth quarter of coordinates";
            else if (x == 0 && y == 0)
                return "The point is at the center of coordinates";
            else
                return "The point does not belong to any of the quarters";
        }
        static public string SortAscendingOrder(int a, int b, int c)
        {
            string sortResult;
            if (a <= b && a <= c)
            {
                if (b != c && b < c)
                    sortResult = $"{a} {b} {c}";
                else
                    sortResult = $"{a} {c} {b}";
            }
            else if (b <= a && b <= c)
            {
                if (a != c && a < c)
                    sortResult = $"{b} {a} {c}";
                else
                    sortResult = $"{b} {c} {a}";
            }
            else if (b != a && b < a)
                sortResult = $"{c} {b} {a}";
            else
                sortResult = $"{c} {a} {b}";
            return sortResult;
        }
        static public double[] SolvingQuadraticEquation(double a, double b, double c)
        {
            double D;
            double x1;
            double x2;
            D = Math.Pow(b, 2) - (4 * a * c);
            if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                double[] x = new double[] { x1, x2 };
                return x;
            }
            else if (D == 0)
            {
                x1 = -b / (2 * a);
                double[] x = new double[] { x1 };
                return x;
            }
            else
            {
                double[] x = new double[] { };
                return x;
            }
        }
        static public string ShowAnswerQuadraticEquation(double[] result)
        {
            string answer;
            if (result.Length == 2)
            {
                answer = $"Equation roots - {result[0]}, {result[1]}.";
            }
            else if (result.Length > 0)
            {
                answer = $"Equation root - {result[0]}.";
            }
            else
            {
                answer = "Equation has no roots";
            }
            return answer;
        }
        static public string WriteUserNumber(int number)
        {
            string writeNumber = "";
            char number1 = Convert.ToString(number)[0];
            char number2 = Convert.ToString(number)[1];
            if (number / 10 == 1)
            {
                switch (number)
                {
                    case 10:
                        writeNumber = "Десять";
                        break;
                    case 11:
                        writeNumber = "Одинадцать";
                        break;
                    case 12:
                        writeNumber = "Двенадцать";
                        break;
                    case 13:
                        writeNumber = "Тринадцать";
                        break;
                    case 14:
                        writeNumber = "Четырнадцать";
                        break;
                    case 15:
                        writeNumber = "Пятнадцать";
                        break;
                    case 16:
                        writeNumber = "Шестнадцать";
                        break;
                    case 17:
                        writeNumber = "Семнадцать";
                        break;
                    case 18:
                        writeNumber = "Восемнадцать";
                        break;
                    case 19:
                        writeNumber = "Девятнадцать";
                        break;
                }
            }
            else if (number / 10 != 1)
            {
                switch (number1)
                {
                    case '2':
                        writeNumber = "Двадцать ";
                        break;
                    case '3':
                        writeNumber = "Тридцать ";
                        break;
                    case '4':
                        writeNumber = "Сорок ";
                        break;
                    case '5':
                        writeNumber = "Пятьдесят ";
                        break;
                    case '6':
                        writeNumber = "Шестьдясят ";
                        break;
                    case '7':
                        writeNumber = "Семьдясят ";
                        break;
                    case '8':
                        writeNumber = "Восемьдесят ";
                        break;
                    case '9':
                        writeNumber = "Девяносто ";
                        break;
                }

            }
            if (number / 10 != 1 && number % 10 != 0)
            {
                switch (number2)
                {
                    case '1':
                        writeNumber += "один";
                        break;
                    case '2':
                        writeNumber += "два";
                        break;
                    case '3':
                        writeNumber += "три";
                        break;
                    case '4':
                        writeNumber += "четыре";
                        break;
                    case '5':
                        writeNumber += "пять";
                        break;
                    case '6':
                        writeNumber += "шесть";
                        break;
                    case '7':
                        writeNumber += "семь";
                        break;
                    case '8':
                        writeNumber += "восемь";
                        break;
                    case '9':
                        writeNumber += "девять";
                        break;
                }
            }
            return writeNumber;
        }
    }
}
