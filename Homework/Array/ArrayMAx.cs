using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Array
{
    class ArrayMax
    {
        static void Main(string[] args)
        {
			int[] a = { 4, 3, 8, 7, 9, 1, 11 };
			int max = 0;

			for (int i = 0; i < a.Length; i++)
			{
				if (a[i] > max)
				{
					max = a[i];
				}
			}
            Console.WriteLine("Max " + max);
		}
    }
}
