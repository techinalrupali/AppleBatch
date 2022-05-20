using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.Containment
{
    class Student
    {
        int stuid;
        string name;
        int percent;
        Batch batch1 = new Batch();
        Address add = new Address();

        public Student(int stuid, string name, int percent, Batch batch1, Address add)
        {
            this.Stuid = stuid;
            this.Name = name;
            this.Percent = percent;
            this.Batch1 = batch1;
            this.Add = add;
        }

        public Student()
        {

        }
        public int Stuid { get => stuid; set => stuid = value; }
        public string Name { get => name; set => name = value; }
        public int Percent { get => percent; set => percent = value; }
        public Batch Batch1 { get => batch1; set => batch1 = value; }
        public Address Add { get => add; set => add = value; }


    }

    class Batch
    {
        string batchname;
        string subject;

        public Batch(string batchname, string subject)
        {
            this.Batchname = batchname;
            this.Subject = subject;
        }

        public Batch()
        {

        }
        public string Batchname { get => batchname; set => batchname = value; }
        public string Subject { get => subject; set => subject = value; }
    }
    class Address
    {
        string street;
        string city;

        public Address(string street, string city)
        {
            this.Street = street;
            this.City = city;
        }

        public Address()
        {

        }
        public string Street { get => street; set => street = value; }
        public string City { get => city; set => city = value; }
    }

      class StudTest
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Stuid = 101;
            s1.Name = "ABC";
            s1.Percent = 80;
            s1.Batch1.Batchname = "Apple";
            s1.Batch1.Subject = "Java";
            s1.Add.Street = "Hotagi Road";
            s1.Add.City = "Solapur";

            Console.WriteLine(s1.Stuid);
            Console.WriteLine(s1.Name);
            Console.WriteLine(s1.Percent);
            Console.WriteLine(s1.Batch1.Batchname);
            Console.WriteLine(s1.Batch1.Subject);
            Console.WriteLine(s1.Add.Street);
            Console.WriteLine(s1.Add.City);

        }
    }
}

