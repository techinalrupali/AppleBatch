using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.ifelse
{
    class EvenOdd
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the Number:");
            num = Convert.ToInt32(Console.ReadLine());

            if(num%2==0)
                Console.WriteLine(num+"Number is Even");
            else
                Console.WriteLine(num+"Number is Odd ");
        }
    }
}
