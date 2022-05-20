using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.ArrayHomework
{
    class Question3
    {
        static void Main(string[] args)
        {

			int[] a = { 4, 5, 6, 8, 9, 6, 5, 5 };
			int count = 0;
			for (int i = 0; i < a.Length; i++)
			{
				for (int j = 0; j < a.Length; j++)
				{
					if (a[i] == a[j] && i > j)
						break;
					if (a[i] == a[j])
						count++;
				}
				if (count != 0)
					Console.WriteLine($"Frenquency of {a[i]} is= " + count);
				count = 0;
			}
		}
    }
}
