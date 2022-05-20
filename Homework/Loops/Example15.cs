using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Loops
{
    class Example15
    {
        static void Main(string[] args)
        {
            int n, m, s = 0, h = 1;
            Console.WriteLine("Enter the number:");
            n = Convert.ToInt32(Console.ReadLine());
            for(m=1;m<=n;m++)
            {
                h = h * m;
                s = s + h;
            }
            Console.WriteLine(s);
        }
    }
}
