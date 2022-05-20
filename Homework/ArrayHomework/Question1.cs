using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.ArrayHomework
{
    class Question1
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] arr2 = { 11, 22, 33, 44 };
            int[] arr3 = new int[arr1.Length + arr2.Length];

            int j = 0;
            for (int i = 0; i <arr3.Length;)
            {
                if (j < arr1.Length && j < arr2.Length)
                {
                    arr3[i] = arr1[j];
                    i++;
                    arr3[i] = arr2[j];
                    i++;
                }
                else if (j < arr1.Length)
                {
                    arr3[i] = arr1[j];
                    i++;
                }
                j++;
            }
            foreach (int d in arr3)
            {
                Console.WriteLine(d + " ");
            }
        }
    }
}
