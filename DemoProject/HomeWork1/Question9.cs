using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject.HomeWork1
{
    //ascending order
    class Question9
    {
        static void Main(string[] args)
        {
            int[] num = { 5, 8, 3, 4, 7, 6, 1 };
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[i] < num[j])
                    {
                        int temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
        }
    }
}
