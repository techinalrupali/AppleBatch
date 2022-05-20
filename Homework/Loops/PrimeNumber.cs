using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Loops
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            int i,a,count;
            Console.WriteLine("Prime Number between 400 to 300 are:");
            for(i=400;i>300;i--)
            {
                count = 0;
                for(a=1;a<=i;a++)
                {
                    if(i%a==0)
                    {
                        count++;
                    }
                    
                }
                if (count == 2)
                    Console.WriteLine(i);

            }
        }
    }
}
