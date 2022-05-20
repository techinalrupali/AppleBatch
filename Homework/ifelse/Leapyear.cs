using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.ifelse
{
    class Leapyear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year:-");
            int year = Convert.ToInt32(Console.ReadLine());

            if(year%4==0)
            {
                Console.WriteLine("This year is leap year");

            }
            else
            {
                Console.WriteLine("This year is not leap year");
            }
        }
    }
}
