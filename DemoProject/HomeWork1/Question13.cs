using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject.HomeWork1
{
    //all unique elements in the array
    class Question13
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 4, 5, 6, 2, 1, 3, 4, 8, 9, 7, 5, 6 };
            int c = 0;
            for(int i=0;i<a.Length;i++)
            {
                for(int j=0;j<a.Length;j++)
                {
                    if (a[i] == a[j])
                        c++;
                    
                }
                if(c==1)
                    Console.WriteLine(a[i]);
                c = 0;
            }
        }
    }
}
