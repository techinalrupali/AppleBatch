using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject
{
    class sumprime
    {
        static void Main(string[] args)
        {
			int[] input = new int[5];
			for (int i = 0; i < input.Length; i++)
			{
				input[i] = Convert.ToInt32(Console.ReadLine());
			}
			int sum = 0;
			for (int i = 0; i < input.Length; i++)
			{
				int j = 2;
				int p = 1;
				while (j < input[i])
				{
					if (input[i] % j == 0)
					{
						p = 0;
						break;
					}
					j++;
				}

				if (p == 1)
				{
					sum = sum + input[i];
				}
			}
            Console.WriteLine(sum);
		}
    }
}
