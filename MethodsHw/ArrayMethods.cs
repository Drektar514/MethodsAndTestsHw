using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsHw
{
    static public class ArraysMethods
    {
        static public int[] CreateRandomIntArray(int count)
        {
            int[] ar = new int[count];
            Random rand = new Random();
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = rand.Next(100);
                Console.Write(ar[i] + " ");
            }
            return ar;
        }
        static public int FindMinEllementArray(int[] ar)
        {
            int min;
            min = ar[0];
            for (int i = 1; i < ar.Length; i++)
            {
                if (ar[i] < min)
                {
                    min = ar[i];
                }
            }
            return min;
        }
        static public int FindMaxEllementArray(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        static public int FindIndexMinEllementArray(int[] array)
        {
            int min = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[min])
                {
                    min = i;
                }
            }
            return min;
        }
        static public int FindIndexMaxEllementArray(int[] array)
        {
            int max = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[max])
                {
                    max = i;
                }
            }
            return max;
        }
        static public int SumEllementsOddIndex(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }
        static public int[] ReversArray(int[] array)
        {
            int[] array2 = new int[array.Length];
            int j = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                array2[j] = array[i];
                j++;
            }
            return array2;
        }
        static public void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        static public int FindCountOddElArray(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    count++;
                }
            }
            return count;
        }
        static public int[] SwapHalfsArray(int[] array)
        {
            int[] swapArray = new int[array.Length];
            Array.Copy(array, swapArray, array.Length);
            int half = array.Length / 2;
            for (int i = 0; i < half; i++)
            {
                int temp = swapArray[i];
                if (swapArray.Length % 2 == 0)
                {
                    swapArray[i] = swapArray[half + i];
                    swapArray[half + i] = temp;
                }
                else
                {
                    swapArray[i] = swapArray[half + i + 1];
                    swapArray[half + i + 1] = temp;
                }
            }
            return swapArray;
        }
        static public int[] SortArrayAscendingBubble(int[] array)
        {
            int[] sortArray = new int[array.Length];
            Array.Copy(array, sortArray, array.Length);
            for (int i = sortArray.Length; i > 0; i--)
            {
                int temp;
                for (int j = 0; j < i - 1; j++)
                {
                    int max = sortArray[j];
                    int min = sortArray[j + 1];
                    if (max > min)
                    {
                        temp = sortArray[j];
                        sortArray[j] = sortArray[j + 1];
                        sortArray[j + 1] = temp;
                    }
                }
            }
            return sortArray;
        }
        static public int[] SortArrayDescendingSelected(int[] array)
        {
            int[] sortArray = new int[array.Length];
            Array.Copy(array, sortArray, array.Length);
            for (int i = 0; i < sortArray.Length; i++)
            {
                int max = sortArray[i];
                int index = i;
                for (int j = i; j < sortArray.Length; j++)
                {
                    if (max < sortArray[j])
                    {
                        max = sortArray[j];
                        index = j;
                    }
                }
                int temp = sortArray[i];
                sortArray[i] = max;
                sortArray[index] = temp;
            }
            return sortArray;
        }
    }
}
