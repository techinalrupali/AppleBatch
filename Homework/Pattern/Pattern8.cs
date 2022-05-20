using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Pattern
{
    class Pattern8
    {
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int k = 1; k < i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = i; j <= 5; j++)
                {
                    Console.Write(j+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}
