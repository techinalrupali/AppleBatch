using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.OOP
{
    class Series
    {
        static void Main(string[] args)
        {
            float fact = 1, t = 0;
            for(int i=1;i<=10;i++)
            {
                for(int j=1;j<=i*2;j++)
                {
                    fact = fact * j;

                }
                t = t + (i / fact);
                fact = 1;
            }
            Console.WriteLine(t);

        }
    }
}
