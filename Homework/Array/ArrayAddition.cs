using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Array
{
    class ArrayAddition
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 6, 7, 8, 9, 5 };
            int[] c = new int[5];
            for (int i = 0; i < 5; i++)
            {
                c[i] = a[i] + b[i];
            }
            for(int i=0;i<5;i++)
            {
                Console.WriteLine(c[i]);
            }    
        }
    }
}
