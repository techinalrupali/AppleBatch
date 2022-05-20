using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Loops
{
    class Power
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Base:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Exponent:");
            int exp = Convert.ToInt32(Console.ReadLine());
            int power = 1;
            int i = 1;
            while(i<=exp)
            {
                power = power * b;
                i++;
            }
            Console.WriteLine(power);

        }
    }
}
