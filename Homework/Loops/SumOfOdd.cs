using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Loops
{
    class SumOfOdd
    {
        static void Main(string[] args)
        {
            int i, n, totalodd = 0;
            Console.WriteLine("Enter the number:");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    totalodd = totalodd + i;
                }
            }
            Console.WriteLine("Sum all odd numbers are:" + totalodd);
        }

    }
}
