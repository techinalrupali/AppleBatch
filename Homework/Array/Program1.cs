using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Array
{
    //add elements to single diamensional int array and print elements from 1D array
    class Program1
    {
        static void Main(string[] args)
        {
            int[] a = { 10, 20, 30, 40, 50, 60 };
            Console.WriteLine("Single Diamensional array elements are:");
            for(int i=0;i<a.Length;i++)
            {
                Console.WriteLine("a["+i+"]="+a[i]);
            }
        }
    }
}
