using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Array
{
    class Program10

    {
		//find maximum and minimum value
        static void Main(string[] args)
        {
			int[] a = { 4, 3, 8, 7, 9, 1, 11 };
			int i, max, min;
			max = a[0];
			min = a[0];
			for(i=1; i <a.Length; i++)
            {
				if (a[i] > max)
				{
					max = a[i];
				}
				if (a[i] < min)
				{
					min = a[i];
				}
            }
            Console.WriteLine("Maximum element="+max);
            Console.WriteLine("Minimum element="+min);

			

			

			 
		}
    }
}
