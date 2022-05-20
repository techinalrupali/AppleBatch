using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.ifelse
{
    class Numberdivisible
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num%5==0 && num%11==0)
            {
                Console.WriteLine("This Number divisible by 5 and 11");
            }
            else
            {
                Console.WriteLine("This Number is not divisible by 5 and 11");
            }
        }

    }
}
