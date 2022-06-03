using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.MyThread
{
    class Class1
    {
        static void m1()
        {
            Console.WriteLine("In M1");
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine("In M1"+i);
            }

            Console.WriteLine("M1 ends");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main starts");
            m1();
            Console.WriteLine("Main ends");
        }
    }


}
