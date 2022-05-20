using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.MyExceptionHomeWork
{
   internal class student1
    {
        string sname;
        int percent;

        public student1(string sname, int percent)
        {
            this.Sname = sname;
            this.Percent = percent;
        }
        public override string ToString()
        {
            return $"Name={sname} Percentage={percent}";
        }
        public int CompareTo(student1 s2)
        {
            return sname.CompareTo(s2.sname);
        }

        public string Sname { get => sname; set => sname = value; }
        public int Percent { get => percent; set => percent = value; }
    }
}

