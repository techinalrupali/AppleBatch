using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.OOP
{
    class MyPen
    {
        string brand;
        string color;
        int price;

        public MyPen(string b)
        {
            Console.WriteLine("in 1st para");
            brand = b;

        }
        public MyPen(string b,string c):this(b)
        {
            Console.WriteLine("in 2nd para");
            color = c;
        }
        public MyPen(string b,string c,int p):this(b,c)
        {
            Console.WriteLine("in 3rd para");
            price = p;
        }

        static void Main(string[] args)
        {
            MyPen mp = new MyPen("Cello", "Blue", 10);
        }
    }


    
}
