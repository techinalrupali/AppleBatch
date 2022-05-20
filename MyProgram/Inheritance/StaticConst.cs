using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.Inheritance
{
    class StaticConst
    {
        int a = 500;
        int sid;
        string sname;
        static int x;
        public StaticConst()
        {
            Console.WriteLine("Default Constructor");
        }

        public StaticConst(int sid,string sname)
        {
            Console.WriteLine("Parameterised Constructor");
            this.sid = sid;
            this.sname = sname;
            Console.WriteLine(sid+" "+sname);
        }
        static StaticConst()
        {
            x = 400;
            Console.WriteLine("Static Constructor"+x);
        }
    }
    class StaticConstTest
    {
        static void Main(string[] args)
        {
            StaticConst s1 = new StaticConst(101, "ABC");
        }
    }
}
