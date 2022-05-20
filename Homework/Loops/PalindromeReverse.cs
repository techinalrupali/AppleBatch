using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Loops
{
    class PalindromeReverse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = n;
            int sum = 0;
            while(n>0)
            {
                int digit = n % 10;
                sum = (sum * 10 )+ digit;
                n = n / 10;
            }
            if (sum == a)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");
            
        }
    }
}
