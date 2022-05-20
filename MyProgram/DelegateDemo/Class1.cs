using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.DelegateDemo
{
    class Class1
    {
        public delegate void mydelegate(int a);
        public static void factorial(int n)
        {
            int fact = 1;
            for (int i = 0; i <= n; i++)
                fact = fact * i;
            Console.WriteLine("Factorial is:");
             
        }
  
        static void Main(string[] args)
        {
            mydelegate f =factorial;
            f(4);


        }
    }
}
