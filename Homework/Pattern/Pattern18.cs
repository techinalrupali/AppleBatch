using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Pattern
{
    class Pattern18
    {
        static void Main(string[] args)
        {
            for (char i = 'E'; i >= 'A'; i--)
            {
                for (char j ='A'; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
