using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Test
{
    class Pattern8
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int k = 4-i; k >= 1; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <=2*i-1; j++)
                {
                        Console.Write(i);
                }
                
                Console.WriteLine();
            }
        }
    }
}
