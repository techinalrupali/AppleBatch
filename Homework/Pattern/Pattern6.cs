using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Pattern
{
    class Pattern6
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int space=5;space>i;space--)
                {
                    Console.Write(" ");
                }
                for(int j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
