using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject
{
    class Emp
    {
        int id;
        string name;
        int salary;

        public Emp(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Salary { get => salary; set => salary = value; }

        static void Main(string[] args)
        {
            Emp[] e1 = new Emp[5]
            {
                new Emp(1,"Maya",50000),
                new Emp(2,"Tina",10000),
                new Emp(3,"Sona",20000),
                new Emp(4,"Mona",40000),
                new Emp(5,"Riya",60000),
            };
            for(int i=0;i<e1.Length;i++)
            {
                if(e1[i].salary>45000)
                {
                    Console.WriteLine("Emp id="+e1[i].id);
                    Console.WriteLine("Emp name=" + e1[i].name);
                    Console.WriteLine("Emp salary=" + e1[i].salary);
                }
            }
            
        }
    }
}
