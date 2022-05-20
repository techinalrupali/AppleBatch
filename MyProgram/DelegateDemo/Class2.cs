using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.DelegateDemo
{
    public delegate void mydelegate(int a);
    class Class2
    {
       
        public static void factorial(int n)
        {
            int fact = 1;
            for (int i = 0; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial is:"+fact);

        }
        public static void prime(int n)
        {
            int c = 0;
            for(int i=2;i<=n;i++)
            {
                if(n%i==0)
                {
                    c++;
                    break;
                }
            }
            if(c==0)
                Console.WriteLine("Prime number:"+n);
            else
                Console.WriteLine("Not Prime");
        }
        static void Main(string[] args)
        {
            mydelegate d1 = factorial;
            d1 += prime;
            d1(3);


        }



    }
}
