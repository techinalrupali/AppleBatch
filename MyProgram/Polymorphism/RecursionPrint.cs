using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.Polymorphism
{
    //print 54321
    class RecursionPrint
    {
        public static void print(int n)
        {
            if(n>0)
            {
                Console.WriteLine(n);
                print(n - 1);
            }
        }
        static void Main(string[] args)
        {
            int s = 5;
            RecursionPrint.print(s);
        }
    }
}
