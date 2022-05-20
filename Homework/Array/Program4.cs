using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Array
{
    //copy array by iterating the array
    class Program4
    {
            static void Main(string[] args)
            {

                int[] arr = { 1, 5, 7, 8, 4, 6, 9 };
                int[] barr = new int[arr.Length];
                System.Array.Copy(arr, barr, arr.Length);
               /* barr[0] =4000;*/
                foreach (int d in arr)
                    Console.WriteLine(d + " ");
                Console.WriteLine("****************************");
                foreach (int d in barr)
                    Console.WriteLine(d + " ");
            }
        }
}
