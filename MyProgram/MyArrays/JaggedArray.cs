using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.MyArrays
{
    class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][] a1 = new int[3][];

            a1[0] = new int[2];
            a1[1] = new int[3];
            a1[2] = new int[4];

            for (int i = 0; i < a1.GetLength(0); i++)
            {
                Console.WriteLine("Enter elements in row:");
                for (int j = 0; j < a1[i].Length; j++)
                {
                    a1[i][j] = int.Parse(Console.ReadLine());
                }

            }
            for (int i = 0; i < a1.GetLength(0); i++)
            {
                Console.WriteLine("Enter elements in row:");
                for (int j = 0; j < a1[i].Length; j++)
                {
                    Console.Write(a1[i][j]+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
