using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject.HomeWork1
{
    //WAP to merge 2 array to 3rd array. 3rd array should not have elements of same value
    class Question8
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 6, 7, 8, 9 };
            int[] c = new int[a.Length + b.Length];
            for(int i=0;i<a.Length;i++)
            {
                c[i] = a[i];
            }
            for(int i=0;i<b.Length;i++)
            {
                c[i + a.Length] = b[i];
            }
            for(int i=0;i<c.Length;i++)
            {
                Console.WriteLine(c[i]);
            }
        }
    }
}
