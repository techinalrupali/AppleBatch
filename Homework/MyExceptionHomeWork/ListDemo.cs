using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Homework.MyExceptionHomeWork
{
    class demo<d>
    {
        d obj;
        public void Add(d o)
        {
            obj = o;
        }
        public d Get()
        {
            return obj;
        }
    }
    class mydemo
    {
        static void Main(string[] args)
        {
            demo<string> b = new demo<string>();
            b.Add("Tina");
       
        }
    }
    class ListDemo
    {
        static void Main(string[] args)
        {

            List< string > l1= new List<string>();
            l1.Add("ABC");
            l1.Add("CBA");
            l1.Remove("CBA");
            l1.Sort();
            l1.Reverse();

            foreach(string d in l1)
                Console.WriteLine(d);

        }
    }
    class demo1
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Sara");
            al.Add("Tina");
            al.Add("Abhi");

            List<string> a2 = new List<string>();
            a2.Add("AA");
            a2.Add("BB");
          //  a2.AddRange((IEnumerable<string>)al);
            foreach(string d in a2)
                Console.WriteLine(d);
            

        }
    }
}
