using System;
using System.Collections.Generic;
using System.Text;


namespace Homework.CollectionHomeWork
{
    class sortEmpBySalary : IComparer<Q8Employee>
    {
        public int Compare(Q8Employee x, Q8Employee y)
        {
            return y.Salary.CompareTo(x.Salary);
        }
    }
    class Question8
    {
        static void Main(string[] args)
        {
            SortedList<Q8Employee, string> e = new SortedList<Q8Employee, string>(new sortEmpBySalary() );
            e.Add(new Q8Employee(101,"Tina",20000), "Prorigo");
            e.Add(new Q8Employee(102, "Ram",30000), "Infosys");
            e.Add(new Q8Employee(103, "Sham",25000), "TCS");
            e.Add(new Q8Employee(104, "Meera",40000), "Capgimini");
            e.Add(new Q8Employee(105, "Priya",35000), "Prorigo");


            foreach(KeyValuePair<Q8Employee,string> d in e)
                Console.WriteLine(d.Key+" "+d.Value);
             
        }
    }
}
