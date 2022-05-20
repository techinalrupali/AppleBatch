using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Homework.MyExceptionHomeWork
{
    class mysort:IComparer
    {
        public int Compare(object o1,object o2)
        {
            StringBuilder s1 = (StringBuilder)o1;
            StringBuilder s2 = (StringBuilder)o2;
            return s1.ToString().CompareTo(s2.ToString());

        }
    }
    class Demo
    {
        static void Main(string[] args)
        {
            SortedList s11 = new SortedList(new mysort());
            s11.Add(new StringBuilder("Maya"), 90);
            s11.Add(new StringBuilder("Tina"), 92);
            s11.Add(new StringBuilder("Sara"), 85);
            s11.Add(new StringBuilder("Priya"), 89);
            s11.Add(new StringBuilder("Pihu"), 95);

            foreach(DictionaryEntry d in s11)
                Console.WriteLine(d.Key+" "+d.Value);

        }
    }
}
