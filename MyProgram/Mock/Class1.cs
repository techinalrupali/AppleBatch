using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace MyProgram.Mock
{
    
    class Employee
    {
        int id;
        string name;

        public Employee(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public override string ToString()
        {
            return $"Id={id} Name={name}";
        }
    }
    class Class1
    {
        static void Main(string[] args)
        {
            HashSet<Employee> h1 = new HashSet<Employee>();
            Dictionary<HashSet<Employee>, string> d1 = new Dictionary<HashSet<Employee>,string>();
           // d1.Add(new Employee(1, "RRB"),"HR");
           // d1.Add(new Employee(2, "ABC"),"Tester");

            foreach (KeyValuePair<HashSet<Employee>,string> dd in d1)
                Console.WriteLine(dd.Key + " " + dd.Value);




        }
    }
}
