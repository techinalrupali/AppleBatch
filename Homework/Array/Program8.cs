using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Array
{
    class Program8
    {
        //print all negative element and count all negative element
        static void Main(string[] args)
        {
            int[] a = { 5, -4, 8, -7, -2, -6, 3 };
            int count = 0;
            Console.WriteLine("All negative elements are:");
            for(int i=0;i<a.Length;i++)
            {
                if (a[i] < 0)
                    Console.WriteLine(a[i]);
                    
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                    count++;

            }
            Console.WriteLine("Total negative elements in array="+count);
        }
    }
}
