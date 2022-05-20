using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Loops
{
    class EvenNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even Numbers are:");
            for(int i=121;i<=229;i++)
            {
                if(i % 2== 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
