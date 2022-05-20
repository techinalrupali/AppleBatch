using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Test
{
    class SpyorNot
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int num = Convert.ToInt32(Console.ReadLine());
			int sum = 0;
			int product = 1;
			while (num > 0)
			{
				int r = num % 10;
				sum = sum + r;
				product = product * r;
				num = num / 10;

			}
			if (sum == product)
			{
				Console.WriteLine("Spy number");

			}
			else
			{
				Console.WriteLine("Not Spy number");
			}
		}
    }
}
