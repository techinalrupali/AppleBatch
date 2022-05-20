using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.CollectionHomeWork
{
    internal class Q8Employee
    {
        int empid;
        string name;
        int salary;

        public Q8Employee(int empid, string name, int salary)
        {
            this.empid = empid;
            this.name = name;
            this.salary = salary;
        }
        public override string ToString()
        {
            return $"Employee id={empid} Employee Name={name} Employee Salary={salary}";
        }
        public int CompareTo(Q8Employee e2)
        {
            return e2.name.CompareTo(name);
        }

        public int Empid { get => empid; set => empid = value; }
        public string Name { get => name; set => name = value; }
        public int Salary { get => salary; set => salary = value; }
    }
}
