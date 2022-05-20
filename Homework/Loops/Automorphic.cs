using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Loops
{
    class Automorphic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int sq = n * n;
            Console.WriteLine("Square:" + sq);
            bool isautomorphic = true;
            int a = n;
            while(n>0)
            {
                int r1 = n % 10;
                int r2 = sq % 10;
                if(r1!=r2)
                {
                    isautomorphic = false;
                }
                n = n / 10;
                sq = sq / 10;

            }
            if(isautomorphic)
                Console.WriteLine("Automorphic");
            else
                Console.WriteLine("Not Automorphic");
 
        }
    }
}
