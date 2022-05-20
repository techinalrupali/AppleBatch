using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace Homework.CollectionHomeWork
{
    class Employee
    {
        string name;
        string designation;
        int salary;

        public Employee(string name, string designation, int salary)
        {
            this.name = name;
            this.designation = designation;
            this.salary = salary;
        }

        public override string ToString()
        {
            return $"Name:={name} designation={designation} salary={salary}";
        }
        public string Name { get => name; set => name = value; }
        public string Designation { get => designation; set => designation = value; }
        public int Salary { get => salary; set => salary = value; }
    }
    class Question2
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>();
            emp.Add(new Employee("Raj", "HR", 80000));
            emp.Add(new Employee("Tina", "Manager", 50000));
            emp.Add(new Employee("Abhi", "Employee", 30000));
            emp.Add(new Employee("Sagar", "CEO", 100000));
            emp.Add(new Employee("Meera", "HR", 80000));

            foreach(var d in emp)
            {
                Console.WriteLine(d);
            }

        }
    }
}
