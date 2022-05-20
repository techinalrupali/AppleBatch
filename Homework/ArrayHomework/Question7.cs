using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.ArrayHomework
{
    class Question7
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 22, 31, 9 }, { 12, 25, 16 } };
            int max = int.MinValue;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                }

                Console.WriteLine($"Maximum element of rowwise in 2D array {i} is:{max} ");
                max = 0;
            }
        }
    }
}
