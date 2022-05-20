using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.ArrayHomework
{
    
    class Question2
    {
        static void Main(string[] args)
        {
            int[] a1 = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int x = 8;
            for(int i=0;i<a1.Length;i++)
            {
                if(x<a1.Length)
                {
                    int temp = a1[i];
                    a1[i] = a1[x];
                    a1[x] = temp;
                    x++;

                }
                Console.Write(a1[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
