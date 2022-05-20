using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Test
{
    //AmicableNumbers
    class AmicableNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two pair number:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int a1 = 0, b1 = 0;
            for(int i=1;i<a;i++)
            {
                if (a % i == 0)
                    a1 += i;

            }
            for(int i=1;i<b;i++)
            {
                if (b % i == 0)
                    b1 += i;
                  
            }
            Console.WriteLine("a1:"+a1);
            Console.WriteLine("b1:"+b1);
            if(a1==b&&b1==a)
                Console.WriteLine("Amicable numbers");
            else
                Console.WriteLine("Not Amicable numbers");

        }
    }
}
