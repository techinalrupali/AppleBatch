using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Loops
{
    class ProductOfDigits
    {
        static void Main(string[] args)
        {
            int n, product=1, k;
            Console.WriteLine("Enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            while(n!=0)
            {
                k = n % 10;
                n = n / 10;
                product =product * k;

            }
            Console.WriteLine("Product of digits of the number:"+product);
        }
    }
}
