using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.Containment
{
    class Person
    {
        int id;
        string name;
        Vehicle v=new Vehicle();

        public Person(int id, string name, Vehicle v)
        {
            this.Id = id;
            this.Name = name;
            this.V = v;
        }
        public Person()
        {

        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public Vehicle V { get => v; set => v = value; }
    }

    class Vehicle      
    {
        int vid;
        string vname;

        public Vehicle(int vid, string vname)
        {
            this.Vid = vid;
            this.Vname = vname;
        }

        public Vehicle()
        {

        }
        public int Vid { get => vid; set => vid = value; }
        public string Vname { get => vname; set => vname = value; }
    }

    class PersonTest
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Id = 101;
            p1.Name = "Rupali";
            p1.V.Vid = 501214;
            p1.V.Vname = "swift";

            Console.WriteLine("Person_Id="+p1.Id);
            Console.WriteLine("Person Name="+p1.Name);
            Console.WriteLine("Vehicle_Id="+p1.V.Vid);
            Console.WriteLine("Vehicle Name="+p1.V.Vname);

            Person p2 = new Person();
            Console.WriteLine("Enter the person id:-");
            p2.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the person name:-");
            p2.Name = Console.ReadLine();
            Console.WriteLine("Enter the vehicle id:-");
            p2.V.Vid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the vehicle name:-");
            p2.V.Vname = Console.ReadLine();

            Console.WriteLine("Person_Id=" + p2.Id);
            Console.WriteLine("Person Name=" + p2.Name);
            Console.WriteLine("Vehicle_Id=" + p2.V.Vid);
            Console.WriteLine("Vehicle Name=" + p2.V.Vname);


        }
    }
}
