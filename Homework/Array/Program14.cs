using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Array
{
    //accept data in 2D array of 3*4and accept data
    class Program14
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 4];
            for(int r=0;r<a.GetLength(0);r++)
            {
                Console.WriteLine("Enter elements on row"+r);
                for (int c = 0; c < a.GetLength(1); c++)
                {
                    a[r, c] = int.Parse(Console.ReadLine());
                }
            }
            for (int r = 0; r < a.GetLength(0); r++)
            {
                for (int c = 0; c < a.GetLength(1); c++)
                {
                    Console.Write(" "+a[r, c]);
                }
                Console.WriteLine();

            }
           
        }

    }
}
