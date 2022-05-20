using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Array
{
    //print Maximum in Columnwise in 2D
    class Program17
    {
        static void Main(string[] args)
        {
            int[,] a = { { 22, 31, 9 }, { 12, 5, 16 },{ 34, 42, 2 } };
            int min = int.MaxValue;
            for (int j = 0; j < a.GetLength(1); j++)
            {
                for (int i = 0; i < a.GetLength(0); i++)
                {
                
                    if (a[i, j] < min)
                    {
                        min = a[i, j];
                    }
                }

                Console.WriteLine($"Minimum element of Columnwise in 2D array {j} is:{min} ");
                
            }
        }
    }
}
