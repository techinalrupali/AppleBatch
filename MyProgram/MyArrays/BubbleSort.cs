using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.MyArrays
{
    //Bubble Sort
    class BubbleSort
    {
        static void Main(string[] args)
        {
            int[] a = { 8, 7, -4, 6, 3, 50 };
            for (int i = 0; i < a.Length; i++)
            {
                int flag = 0;
                for (int j = 0; j < a.Length - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        flag = 1;
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }

                }
                if (flag == 0)
                    break;
                
            }
            foreach (int d in a)
                Console.Write(d + " ");
         

        }
    }
}
