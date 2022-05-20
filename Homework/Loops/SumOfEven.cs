using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Loops
{
    class SumOfEven
    {
        static void Main(string[] args)
        {
            int i, n, totaleven = 0;
            Console.WriteLine("Enter the number:");
            n = Convert.ToInt32(Console.ReadLine());
            for(i=0;i<n;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                    totaleven = totaleven + i;
                }
            }
            Console.WriteLine("Sum all evennumbers are:"+totaleven);
        }
    }
}
