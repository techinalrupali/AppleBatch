using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Array
{
    class Program9
    {
        static void Main(string[] args)
        {
			int[] a  = { 5, 8, 2, 6, 4, 9, 10, 11, 13, 17 };
            Console.WriteLine("Even numbers are:");
			for (int i = 0; i < a.Length; i++)
			{
				if (a[i] % 2 == 0)
				{
                    Console.WriteLine(a[i]);
				}
			}
			Console.WriteLine("Odd numbers are:");
			for (int i = 0; i < a.Length; i++)
			{
				if (a[i] % 2!= 0)
				{
					Console.WriteLine(a[i]);
				}
			}
		}
    }
}
