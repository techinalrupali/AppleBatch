using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Loops
{
    //Krishnamurthy or not
    class Krishnamurthy
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int a = Convert.ToInt32(Console.ReadLine());
            int n = 1, result = 0;
            int m = a;
            int fact = 1;
            for(int i=0;i<=m; i++)
            {
                n = m % 10;
                m = m / 10;
                for(int j=1;j<=n;j++)
                {
                    fact = fact * j;
                }
                result = result + fact;
                fact = 1;
                i = 0;
            }
            Console.WriteLine("Sum of factors of digit="+result);
            Console.WriteLine();
            if(result==a)
                Console.WriteLine("Krishnamurthy");
            else
                Console.WriteLine("Not a Krishnamurthy");
        }
    }
}
