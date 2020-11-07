using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsHw
{
    static public class TwoDimensoinalArrayMethods
    {
        static public int[,] CreateTwoDimensionalArray(int lenght1, int lenght2)
        {
            int[,] array = new int[lenght1, lenght2];
            Random rand = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(100);
                    if (array[i, j] >= 0 && array[i, j] <= 9)
                        Console.Write(" ");
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            return array;
        }
        static public int FindMinElArray(int[,] array)
        {
            int min = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                    }
                }
            }
            return min;
        }
        static public int FindMaxElArray(int[,] array)
        {
            int max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                    }
                }
            }
            return max;
        }
        static public int[] FindIndexMinElArray(int[,] array)
        {
            int[] indexs = new int[2];
            int index1 = 0;
            int index2 = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[index1, index2] > array[i, j])
                    {
                        index1 = i;
                        index2 = j;
                    }
                }
            }
            indexs[0] = index1;
            indexs[1] = index2;
            return indexs;
        }
        static public int[] FindIndexMaxElArray(int[,] array)
        {
            int[] indexs = new int[2];
            int index1 = 0;
            int index2 = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[index1, index2] < array[i, j])
                    {
                        index1 = i;
                        index2 = j;
                    }
                }
            }
            indexs[0] = index1;
            indexs[1] = index2;
            return indexs;
        }
        static public int FindCountElBiggerNeighbors(int[,] array)
        {
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    bool left = ((j != 0 && array[i, j] > array[i, j - 1]) || j == 0);
                    bool right = ((j != array.GetLength(1) - 1 && array[i, j] > array[i, j + 1]) || j == array.GetLength(1) - 1);
                    bool top = ((i != 0 && array[i, j] > array[i - 1, j]) || i == 0);
                    bool bottom = ((i != array.GetLength(0) - 1 && array[i, j] > array[i + 1, j]) || i == array.GetLength(0) - 1);

                    if (left && right && top && bottom)
                    {
                        Console.Write($"Число большее своих соседей - {array[i, j]}, находиться на позиции - {i},{j} ");
                        count++;
                    }
                }
            }
            return count;
        }
        static public int[,] FlipMainDiagonal(int[,] array)
        {
            int[,] secondArray = new int[array.GetLength(1), array.GetLength(0)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    secondArray[j, i] = array[i, j];
                }
            }
            return secondArray;
        }
        static public void ShowArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
