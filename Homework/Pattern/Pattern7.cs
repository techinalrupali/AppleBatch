using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Pattern
{
    class Pattern7
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for(int k=5;k>i;k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
