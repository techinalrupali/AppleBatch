using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Array
{
    //print Maximum in rowwise in 2D
    class Program16
    {
        static void Main(string[] args)
        {
            int[,] a = { { 22, 31, 9 }, { 12, 25, 16 } };
            int max = int.MinValue;
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    if(a[i,j]>max)
                    {
                        max = a[i, j];
                    }
                }

                Console.WriteLine($"Maximum element of rowwise in 2D array {i} is:{max} ");
                max = 0;
            }
           

        }
    }
}
