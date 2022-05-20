using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.ArrayHomework
{
    class Question4
    {
        static void Main(string[] args)
        {
            int[] a1 = { 1, 2, 3, -4, -1, 4 };
            int n = a1.Length;
            int j = 0, temp;
            for (int i = 0; i < n; i++)
            {
                if (a1[i] < 0)
                {
                    temp = a1[i];
                    a1[i] = a1[j];
                    a1[j] = temp;
                    j++;
                }
            }
            for (int i = 0; i < n; i++)
            {
               Console.WriteLine(a1[i]+" ");

            }
        }

    }
}
