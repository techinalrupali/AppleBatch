using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Pattern
{
    class Pattern13
    {
        static void Main(string[] args)
        {
            for(char i='A';i<='E';i++)
            {
                for(int k='E';k>=i;k--)
                {
                    Console.Write(" ");
                }
                for(char j='A';j<=i;j++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
