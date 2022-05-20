using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.DelegateDemo
{
    //anonymous method
    //method-1
    class Class3
    {
        public delegate void greetdelegate(string name);
        public static void greet(string nm)
        {
            Console.WriteLine("Good Morning "+nm);
        }

        static void Main(string[] args)
        {
            greetdelegate g1 = greet;
            g1("XYZ");
        }
    }


    //method-2
    class Demo12
    {
        public delegate void greetdelegate(string name);
        static void Main(string[] args)
        {
            greetdelegate g1 = delegate (string nm)
              {
                  Console.WriteLine("Good Morning, Have a nice day..!!!" + nm);
              };
            g1("ABC");

        }
    }


    class LamdaDemo
    {
        public delegate int add(int a, int b, int c);
        static void Main(string[] args)
        {
            /*
            add d1 = (a, b, c) =>
              {
                  int sum = a + b + c;
                  return sum;
              };

            int result = d1(10, 20, 30);
            Console.WriteLine(result);
            */

            add a1 = (x, y, z) => x + y + z;
            int result = a1(10, 20, 30);
            Console.WriteLine(result);

        }
    }

    //func method
    class Demo13
    {
        //public delegate int deladd(int a, int b);
        public static int add(int a,int b)
        {
            int sum = a + b;
            return sum;
        }

        static void Main(string[] args)
        {
            Func<int, int, int> del1 = add;
            int result=del1(10, 20);
            Console.WriteLine(result);

        }
    }

    //action method

    class Demo14
    {
        public static void add(int a,int b, float c,double d)
        {
           
            Console.WriteLine(a+b+c+d);
        }

        static void Main(string[] args)
        {
            Action<int, int, float, double> d2 = add;
            d2(10, 20, 5.5f, 30.30);

        }
    }

    //Predicate method
    
    class Demo15
    {
        public static bool Iseven(int a)
        {
            if (a % 2 == 0)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            Predicate<int> d1 = Iseven;
            bool result = d1(6);
            Console.WriteLine(result);

        }
    }
    
}
