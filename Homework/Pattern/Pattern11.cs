using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Pattern
{
    class Pattern11
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {

                for (int k = 5; k > i; k--)
                {
                    Console.Write(" ");
                }

                for (int j =1; j <= (i*2)-1; j++)
                {
                    Console.Write("*");
                
                }
                Console.WriteLine();
            }
        }
    }
}
