using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Homework.MyExceptionHomeWork
{
    class DemoHashSet
    {
        static void Main(string[] args)
        {
            HashSet<string> hs1 = new HashSet<string>()
            {"A","B","a","V","D","T","M" };

            HashSet<string> hs2 = new HashSet<string>()
            {"a","D","M","A","r"};

            Console.WriteLine(hs1.IsProperSubsetOf(hs2));
            Console.WriteLine(hs2.IsProperSubsetOf(hs1));


        }
    }

    internal class stud:IComparable<stud>
    {
        string sname;
        int percent;

        public stud(string sname, int percent)
        {
            this.sname = sname;
            this.percent = percent;
        }
        public int CompareTo(stud s2)
        {
            return sname.CompareTo(s2.sname);
        }

        public string Sname { get => sname; set => sname = value; }
        public int Percent { get => percent; set => percent = value; }

        public override bool Equals(object obj)
        {
            return obj is stud stud &&
                   sname == stud.sname &&
                   percent == stud.percent;
        }
       
        public override int GetHashCode()
        {
            return HashCode.Combine(sname, percent);
        }
        public override string ToString()
        {
            return $"Name={sname} Percentage={percent}";
        }
    }

    class HashsetDemo1
    {
        static void Main(string[] args)
        {
            HashSet<stud> hs = new HashSet<stud>();
            hs.Add(new stud("A", 80));
            hs.Add(new stud("B", 90));
            hs.Add(new stud("R", 85));
            hs.Add(new stud("C", 90));
            hs.Add(new stud("B", 82));

            foreach(stud ob in hs)
                Console.WriteLine(ob);
        }
    }
}
