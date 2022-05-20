using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.Polymorphism
{

    //recursion factorial
    class RecursionFact
    {
         public static int factorial(int n)
        {
            if (n == 1)
                return 1;
            else
            {
                int ans = factorial(n - 1);
                return n * ans;
            }
        }
        static void Main(string[] args)
        {
            int r = 3;
            RecursionFact.factorial(r);
            Console.WriteLine(RecursionFact.factorial(r));
        }
    }
}
