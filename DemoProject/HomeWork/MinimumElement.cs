using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject.HomeWork
{
    class MinimumElement
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 5, 8, 9, 2, 7, 3 };
            int min = a[0];
            for(int i=0;i<a.Length;i++)
            {
                if(min>a[i])
                {
                    min = a[i];
                }
            }
            Console.WriteLine("Minimum Elements is="+min);
        }
    }
}
