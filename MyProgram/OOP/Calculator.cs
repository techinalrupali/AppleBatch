using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.OOP
{
    class Calculator
    {
        public void add(int a,int b,int c)
        {
            int sum = a + b+c;
            Console.WriteLine(sum);
        }
        public int factorial(int n)
        {
            int fact = 1, i;
            for (i = 1; i < n; i++)
                fact = fact * i;
            return fact;

        }
        public bool isprime(int n)
        {
            int flag = 0;
            for(int i=2;i<n;i++)
            {
                if(n%i==0)
                {
                    flag = 1;
                    break;

                }
            }
            if (flag == 0)
                return true;
            else
                return false;
                

        }
        public string greet(String nm)
        {
            return "Good Afternoon" + nm;
        }
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.add(10, 20, 30);
            int f = c.factorial(6);
            bool b = c.isprime(6);
            string s=c.greet("Rupali");

            Console.WriteLine($"Factorial={f}");
            Console.WriteLine($"Prime={b}");
            Console.WriteLine($"Greet={s}");
        }

           


    }
}
