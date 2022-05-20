using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject.HomeWork
{
    class OddElement
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 4, 5, 3, 7, 8, 9, 6 };
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }
        

    }
}
