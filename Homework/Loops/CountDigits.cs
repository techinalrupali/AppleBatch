using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Loops
{
    class CountDigits
    {
        static void Main(string[] args)
        {
            int n;
            int count = 0;
            Console.WriteLine("Enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            while(n!=0)
            {
                n = n / 10;
                count++;

            }
            Console.WriteLine("The number of digits in an integer is:"+count);
        }
    }
}
