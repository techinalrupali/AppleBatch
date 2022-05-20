using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.ArrayHomework
{
    //separate zeros from non zeros in a interger array
    class Question5
    {
        static void Main(string[] args)
        {
            int[] a1 = { 12, 0, 7, 0, 8, 0, 3 };
            int y = 0;
            for(int i=0;i<a1.Length;i++)
            {
                if (a1[i] != 0)
                    y++;
            }
            int[] n = new int[y];
            int[] sortarr = new int[a1.Length];
            int c = 0;
            for(int i=0;i<a1.Length;i++)
            {
                if(a1[i]!=0)
                {
                    n[c] = a1[i];
                    c++;
                }
            }
            c = 0;
            for(int i=0;i<a1.Length;i++)
            {
                if (n.Length - c != 0)
                    sortarr[i] = n[i];
                else
                    break;
                c++;
            }
           
            for(int i=0;i<sortarr.Length;i++)
            {
                Console.WriteLine(sortarr[i]);
            }
            
        }
    }
}
