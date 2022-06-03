using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.PractiseDemo

{
    class Department
    {
        //data member
        public int id;
        public string name;
        public string location;

        public Department()
        {
        }

        public Department(int id, string name, string location)//argument/parameter
        {
            //this refer to the data member
            this.id = id;
            this.name = name;
            this.location = location;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Location { get => location; set => location = value; }

        public override string ToString()
        {
            return $"id={id} name={name} location={location}";
        }
    }

    class DepartmentTest
    {
        static void Main(string[] args)
        {

            
            //Property initializer
            Department d1 = new Department();
            d1.Id = 1;
            d1.Name = "ABC";
            d1.Location = "Solapur";

            Console.WriteLine("Id" + d1.Id);
            Console.WriteLine("Name" + d1.Name);
            Console.WriteLine("Location" + d1.Name);

            //object intializer
            Department dept = new Department( 2, "BCD", "Pune");
            //named Arguments
            Department d11 = new Department(name: "SSS", id: 3, location: "Pune");

            Console.WriteLine(d1);//Implict call to the Tostring()
            Console.WriteLine(dept.ToString());//Explict call to the Tostring()
        }
    }

    //without using varible
     class department1
     {
        //auto inmplemented property
        public int id
        {
            get ;
            set;
        }
        public string name
        {
            get;
            set;
        }
        public string location
        {
            get;
            set;
        }
    }

    class depatTest
    {
        static void Main(string[] args)
        {
            department1 d2 = new department1();
            d2.id = 1;
            d2.name = "ABC";
            d2.location = "Solapur";

            Console.WriteLine("Id" +d2.id);
            Console.WriteLine("Name" + d2.name);
            Console.WriteLine("Location" + d2.location);
        }

    }
    class emp
    {
        public static int count;
        public int id ;
        public string name; //instanace(object)member
        public double salary;

        public emp(string name,double salary)
        {
            count++;
            id = count;
            this.name = name;
            this.salary = salary;
            

        }
        public override string ToString()
        {
            return $"Id={id} name={name} salary={salary}";

        }
        public static void ShowCount()
        {
            Console.WriteLine($"Total Employee= {count}");
        }
        static void Main(string[] args)
        {
            emp e1 = new emp("Tina", 20000);
            emp e2 = new emp("Radha", 25000);
            emp e3 = new emp("Siya", 30000);

            Console.WriteLine(e1);
            Console.WriteLine(e2);
            Console.WriteLine(e3);
            emp.ShowCount();
            
        }
    }

}

