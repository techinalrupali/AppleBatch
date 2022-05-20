using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.OOP
{
    class Employee
    {
        int emp_id;
        string name;
        int salary;

        public void setEmp_id(int emp_id)
        {
            this.emp_id = emp_id;
        }
        public int getEmp_id()
        {
            return emp_id;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public void setSalary(int salary)
        {
            this.salary = salary;
        }
        public int getSalary()
        {
            return salary;
        }

        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.setEmp_id(101);
            e1.setName("XYZ");
            e1.setSalary(20000);

            Employee e2= new Employee();
            e2.setEmp_id(102);
            e2.setName("ABC");
            e2.setSalary(30000);

            Console.WriteLine("id="+e1.getEmp_id());
            Console.WriteLine("Name="+e1.getName());
            Console.WriteLine("Salary="+e1.getSalary());

            Console.WriteLine("id=" + e2.getEmp_id());
            Console.WriteLine("Name=" + e2.getName());
            Console.WriteLine("Salary=" + e2.getSalary());
        }
    }
}
