using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Pattern
{
    class Pattern10
    {
        static void Main(string[] args)
        {
            for (char i = 'E'; i >='A'; i--)
            {
                
                for (int k = 'A'; k <= i; k++)
                {
                    Console.Write(" ");
                }
                
                for (char j = i; j <= 'E'; j++)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
