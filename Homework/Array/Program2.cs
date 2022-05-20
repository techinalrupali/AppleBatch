using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Array
{
    //Calculate the average value of array elements
    class Program2
    {
        static void Main(string[] args)
        {
            int[] a = { 10, 44, 36, 85, 42, 63 };
            int sum = 0;
            for(int i=0;i<a.Length;i++)
            {
                sum = sum + a[i];
                
            }
            double average = sum / a.Length;
            Console.WriteLine("Average value of the array is:"+average);
        }
    }
}
