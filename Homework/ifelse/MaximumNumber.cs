using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.ifelse
{
    class MaximumNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Three Number:-");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            if(num1>num2 || num1>num3)
            {
                Console.WriteLine(num1+ "Num1 is Maximum Number");
            }
            else if(num2>num3)
            {
                Console.WriteLine(num2+ "Num2 is Maximum Number");
            }
            else
            {
                Console.WriteLine(num3+ "Num3 is Maximum Number");
            }
        }
    }
}
