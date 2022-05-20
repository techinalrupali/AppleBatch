using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace MyProgram.MyArrays


{
    class SortArray
    {
        static void Main(string[] args)
        {
            int[] a = { 11, 68, 55, 22, 9, 5, -2, 6 };
            foreach (int d in a)
                Console.WriteLine(d + " ");
           System. Array.Reverse(a);
            Console.WriteLine("**************************");
            foreach(int d in a)
                Console.WriteLine(d+" ");
        }
    }


    class MySortCopy


    {
        static void Main(string[] args)
        {

            int[] arr = { 1, 5, 7, 8, 4, 6, 9 };
            int[] barr = new int[arr.Length];
            System. Array.Copy(arr, barr, arr.Length);
            barr[0] = 5000;
            foreach(int d in arr)
                Console.WriteLine(d+" ");
            Console.WriteLine("****************************");
            foreach(int d in barr)
                Console.WriteLine(d+" ");
        }
    }
}
