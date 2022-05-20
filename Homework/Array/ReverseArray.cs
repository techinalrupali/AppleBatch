using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Array
{
    class ReverseArray
    {
        static void Main(string[] args)
        {
            int[] a = { 11, 15, 19, 22, 30, 98 };
            
			int j = a.Length - 1;
            Console.WriteLine("Reverse Array are:");
			for (int i = 0; i < a.Length / 2; i++)
			{
				int temp = a[i];
				a[i] = a[j];
				a[j] = temp;
				j--;
			}
			for (int i = 0; i < a.Length; i++)
			{
				
				Console.WriteLine(a[i]);
			}

		}
    }
}
