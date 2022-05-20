using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Pattern
{
    class Pattern5
    {
        static void Main(string[] args)
        {
            for(char i='A';i<='E';i++)
            {
                for(char j='A';j<=i;j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
