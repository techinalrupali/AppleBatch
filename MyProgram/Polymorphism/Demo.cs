using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.Polymorphism
{
    //override
    class Parent1
    {
        public void p1()
        {
            Console.WriteLine("I am p1 method");

        }
        public virtual void p12()              //ovrriding
        {
            Console.WriteLine("I am p12 method");
        }
        public virtual void p2()            
        {
            Console.WriteLine("I am p2 method");
        }
        public void p3()          //method hiding
        {
            Console.WriteLine("I am p3 method");
        }
     /*
        static virtual void m1()              //accessing static override
        {
            Console.WriteLine("I am static m1 method as parent");
        }
     */
    }

    sealed class child1:Parent1       //accessing sealed for before class
    {
        public override void p12()           ////ovrriding
        {
            Console.WriteLine("I am p12 method");
        }
        public sealed override void p2()   //accessing sealed for method
        {
            Console.WriteLine("I am p2 method");
        }
        public void p3()
        {
            Console.WriteLine("I am p3 method");
        }
      /*  
        static override void m1()           //static override
        {
            Console.WriteLine("I am static m1 method");
        }
        
      
        class subclass:child1
        {
            public override void p2()
            {
                Console.WriteLine("I am subclass of p2");
            }
        }
      */
    }
    class Test12
    {
        static void Main(string[] args)
        {
            Parent1 p12 = new Parent1();
            p12.p1();
            Parent1 p13 = new child1();
            p13.p12();                   //overriding calling
            p13.p2();
            p13.p3();                   //method hiding calling
           
            

        }
    }

}
