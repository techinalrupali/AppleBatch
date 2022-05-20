using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.MyArrays
{
    //ref and out keywords
    class Demo1
    {
        public static void m1(ref int a)
        {
            a = a + 10;
        }
        public static void m2(int a,int b,out int c, out int d)
        {
            c= a + b;
            d = a - b;
           Console.WriteLine($"C={c}, D={d}");
        }

        static void Main(string[] args)
        {
            int x = 10;
            m1(ref x);
            Console.WriteLine(x);
            int sum, diff;
            m2(20, 10, out sum, out diff);
            
        }
    }
}
