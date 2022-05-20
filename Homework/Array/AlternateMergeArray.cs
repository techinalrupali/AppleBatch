using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Array
{
    class AlternateMergeArray
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 6, 7, 8, 9 };
            int[] c = new int[a.Length + b.Length];

            int j = 0;
            for(int i=0;i<c.Length;)
            {
                if (j < a.Length && j < b.Length)
                {
                    c[i] = a[j];
                    i++;
                    c[i] = b[j];
                    i++;
                }
                else if(j<a.Length)
                {
                    c[i] = a[j];
                    i++;
                }
                j++;
            }
            foreach(int d in c)
            {
                Console.WriteLine(d + " ");
            }
        }
    }
}
