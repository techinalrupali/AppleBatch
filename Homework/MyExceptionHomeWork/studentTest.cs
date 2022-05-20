using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.MyExceptionHomeWork
{
    class sortStudByPercent:IComparer<student1>
    {
        public int Compare(student1 x,student1 y)
        {
            return x.Percent.CompareTo(y.Percent);
        }
    }
    class studentTest
    {
        static void Main(string[] args)
        {
            SortedList<student1, string> s1 = new SortedList<student1, string>(new sortStudByPercent());
            s1.Add(new student1("Tina", 95), "Prorigo");
            s1.Add(new student1("Mina", 85), "Infosys");

            foreach(KeyValuePair<student1,string>k in s1)
            {
                Console.WriteLine(k.Key+" "+k.Value);
            }

        }
    }
}
