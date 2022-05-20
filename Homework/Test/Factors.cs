using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Test
{
    class Factors
    {
        static void Main(string[] args)
        {
            int i, n;
            Console.WriteLine("Enter the Number:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Factors of" +n+" are:");
            for(i=1;i<=n;i++)
            {
                if(n%i==0)
                {
                    Console.WriteLine(i+" ");
                }
            }

        }
    }
}
