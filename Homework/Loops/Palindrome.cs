using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Loops
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palindrome numbers between 100 to 500:");
            for (int i = 100; i <= 500; i++)
            {
                int n=i;
                int sum = 0;
                while (n>0)
                {
                    int digit = n % 10;
                    sum = sum * 10 + digit;
                    n = n / 10;
                }

                if (sum == i)
                    Console.WriteLine(i);
            }
        }
    }
}
