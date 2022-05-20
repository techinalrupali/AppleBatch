using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.Inheritance
{
    class Teacher
    {
        int tid;
        string tname;
        long tmoblieNo;

        public Teacher(int tid, string tname, long tmoblieNo)
        {
            this.tid = tid;
            this.tname = tname;
            this.tmoblieNo = tmoblieNo;
        }
    }
    class HourlyBased:Teacher
    {
        int rate_per_hr;
        int hrs;

        public HourlyBased(int tid,string tname,long tmmoblieNo,int rate_per_hr,int hrs):base(tid,tname,tmmoblieNo)
        {
            this.rate_per_hr = rate_per_hr;
            this.hrs = hrs;
        }
        public void Salary()
        {
            Console.WriteLine("In this HourlyBased");
        }
    }
    class SalaryBased:Teacher
    {
        int salary;

        public SalaryBased(int tid,string tname,long tmoblieNo,int salary):base(tid,tname,tmoblieNo)
        {
            this.salary = salary;
        }
        public void Salary()
        {
            Console.WriteLine("In this SalaryBased");
        }
    }

    class TeacherTest
    {
        static void Main(string[] args)
        {
            HourlyBased h = new HourlyBased(101, "Rupali", 8596412360, 2000, 15);
            h.Salary();
            SalaryBased s = new SalaryBased(102, "Rita", 9526841369, 1000);
            s.Salary();

        }
    }
}
