using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject.HomeWork1
{
    //Replace all negative values wits its immediate left elements square
    class Question11
    {
        static void Main(string[] args)
        {
			int[] a = { 12,3,-19,29,5,-61,44,7,-9 };
			for (int i = 0; i < a.Length; i++)
			{
				if (a[i] < 0)
				{
					a[i] = (a[i - 1] * a[i - 1]);
				}
			}
			for (int i = 0; i <a.Length ; i++)
			{
                Console.WriteLine(a[i]);
			}
		}
    }
}
