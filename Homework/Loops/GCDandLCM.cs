using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Loops
{
    class GCDandLCM
    {
        static void Main(string[] args)
        {
            int num1, num2, gcd, lcm, remainder, numerator, denominator;
            Console.WriteLine("Enter two numbers:");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            if(num1>num2)
            {
                numerator = num1;
                denominator = num2;
            }
            else
            {
                numerator = num2;
                denominator = num1;
            }
            remainder = numerator % denominator;
            while(remainder!=0)
            {
                numerator = denominator;
                denominator = remainder;
                remainder = numerator % denominator;
            }
            gcd = denominator;
            lcm = num1 * num2 / gcd;
            Console.WriteLine("GCD=" +gcd);
            Console.WriteLine("LCM="+lcm);

        }
    }
}
