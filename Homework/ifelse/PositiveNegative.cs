using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.ifelse
{
    class PositiveNegative
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int num = Convert.ToInt32(Console.ReadLine());
             
            if(num<0)
                Console.WriteLine(num+"Number is Negative");
            else if(num>0)
                Console.WriteLine(num+"Number is Positive");
            else
                Console.WriteLine("Number is Zero ");
        }
    }
}
