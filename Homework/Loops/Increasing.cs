using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Loops
{
    class Increasing
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int a = Convert.ToInt32(Console.ReadLine());
            bool isincrease= true;
            bool isdecrease = true;

            int next = a % 10;
            a = a / 10;
            while(a>0)
            {
                int prev = a % 10;
                if (prev > next)
                    isincrease = false;
                if (prev < next)
                    isdecrease = false;

                a = a / 10;
                next = prev;

            }
            if(isdecrease&&isincrease)
                Console.WriteLine("All are equal");
            else if(isincrease)
                Console.WriteLine("Number is increasing");
            else if(isdecrease)
                Console.WriteLine("Number is decreasing");
            else
                Console.WriteLine("bouncy");
        }
    }
}
