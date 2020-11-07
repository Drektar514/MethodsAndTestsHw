using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsHw
{
    static public class Cicle
    {
        static public int RaiseToPower(int a, int b)
        {
            int multiplier = a;
            for (int i = 0; i < b - 1; i++)
            {
                a *= multiplier;
            }
            return a;
        }
        static public int[] ShowAllNumbersFissileOnA(int a)
        {
            int[] numbers = new int[999 / a];
            int index = 0;
            for (int i = a; i < 1000; i += a)
            {
                if (i % a == 0)
                {
                    numbers[index] = i;
                    index++;
                }
            }
            return numbers;
        }

        static public int ShowCountNumberSquareBiggerA(int a)
        {
            int count = 0;
            for (int i = 1; Math.Pow(i, 2) < a; i++)
            {
                count += 1;
            }
            return count;
        }
        static public int ShowGreatestDivisor(int a)
        {
            int divisor = 0;
            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                    divisor = i;
            }
            return divisor;
        }
        static public int SumNumbersABDividedBy7(int a, int b)
        {
            int sum = 0;
            if (a > b)
            {
                int c = a;
                a = b;
                b = c;
            }
            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        static public int ShowNumberSeriesFibonacci(int a)
        {
            int F1 = 0;
            int F2 = 1;
            int F = 0;
            for (int i = 1; i < a; i++)
            {
                F = F1 + F2;
                F1 = F2;
                F2 = F;
            }
            return F;
        }
        static public int FindGCD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }
            return a + b;
        }
        static public int FindNumberFromCubeWithHalfDivision(int a)
        {
            int min = 0;
            int max = a;
            int needNumber = a;
            while (needNumber * needNumber * needNumber != a)
            {
                needNumber = (min + max) / 2;
                if (needNumber < a)
                {
                    max = needNumber;
                }
                else
                {
                    min = needNumber;
                }
            }
            return needNumber;
        }
        static public int FindCountOddNumbers(int A)
        {
            int a;
            int count = 0;
            while (A != 0)
            {
                a = A % 10;
                if (a % 2 != 0)
                {
                    count++;
                }
                A = A / 10;
            }
            return count;
        }
        static public int FindReversNumber(int A)
        {
            int a;
            int B = 0;
            while (A != 0)
            {
                a = A % 10;
                B = B * 10 + a;
                A = A / 10;
            }
            return B;
        }
        static public int ShowCountSumEvenGreatestObb(int A)
        {
            int a;
            int count = 0;
            for (int i = 1; i < A; i++)
            {
                int oddNumb = 0;
                int evenNumb = 0;
                a = i;
                while (a > 0)
                {
                    int b;
                    b = a % 10;
                    if (b % 2 != 0)
                    {
                        oddNumb += b;
                    }
                    else
                    {
                        evenNumb += b;
                    }
                    a = a / 10;
                }
                if (evenNumb > oddNumb)
                    count++;
            }
            return count;
        }
        static public string CompareByNumbers(int A, int B)
        {
            int a = 0;
            int b = 0;
            int tempB = B;
            string result;
            while (A > 0)
            {
                a = A % 10;
                while (B > 0)
                {
                    b = B % 10;
                    if (b == a)
                    {
                        break;
                    }

                    B = B / 10;
                }
                B = tempB;
                if (b == a)
                {
                    break;
                }
                A = A / 10;
            }
            if (b == a)
                result = "Yes";
            else
                result = "No";
            return result;
        }
    }
}
