using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Loops
{
    class Harshad
    {
        static void Main(string[] args)
        {
            int i, d, a, s = 0;
            Console.WriteLine("Enter the number:");
            a = Convert.ToInt32(Console.ReadLine());
            for(i=a;i>0;i=i/10)
            {
                d = i % 10;
                s=s+1;

            }
            if(a%s==0)
                Console.WriteLine("Harshad Number");
            else
                Console.WriteLine("Not a Harshad number");
        }
    }
}
