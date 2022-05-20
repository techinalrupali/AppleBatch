using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.MyArrays
{
    partial class PartialDemo 
    {
        public void m2()
        {
            Console.WriteLine("I am m2 method");
        }
    }
    class partialTest
    {
        static void Main(string[] args)
        {
            PartialDemo p1 = new PartialDemo();
            p1.m1();
            p1.m2();
        }
    }
}
