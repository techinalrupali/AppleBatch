using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.Containment
{
    class Flat
    {
        int flat_no;
        string buildingname;
        Member memberobj=new Member();

        public Flat(int flat_no, string buildingname, Member memberobj)
        {
            this.Flat_no = flat_no;
            this.Buildingname = buildingname;
            this.Memberobj = memberobj;
        }
        public Flat()
        {

        }
        public int Flat_no { get => flat_no; set => flat_no = value; }
        public string Buildingname { get => buildingname; set => buildingname = value; }
        internal Member Memberobj { get => memberobj; set => memberobj = value; }
    }

    class Member
    {
        string membername;
        char gender;
        int age;
        string profession;

        public Member(string membername, char gender, int age, string profession)
        {
            this.Membername = membername;
            this.Gender = gender;
            this.Age = age;
            this.Profession = profession;
        }
        public Member()
        {

        }
        public string Membername { get => membername; set => membername = value; }
        public char Gender { get => gender; set => gender = value; }
        public int Age { get => age; set => age = value; }
        public string Profession { get => profession; set => profession = value; }
    }

    class FlatTest
    {
        static void Main(string[] args)
        {
            Flat f1 = new Flat();
            f1.Flat_no = 621;
            f1.Buildingname = "Kirti Apartment";
            f1.Memberobj.Membername = "Rupali Birajdar";
            f1.Memberobj.Gender = 'F';
            f1.Memberobj.Age = 22;
            f1.Memberobj.Profession = "Software Engineer";

            Console.WriteLine("Flat_No:"+f1.Flat_no);
            Console.WriteLine("Building Name="+f1.Buildingname);
            Console.WriteLine("Member Name="+f1.Memberobj.Membername);
            Console.WriteLine("Gender="+f1.Memberobj.Gender);
            Console.WriteLine("Age="+f1.Memberobj.Age);
            Console.WriteLine("Profession="+f1.Memberobj.Profession);
            Console.WriteLine();


        }
    }
}
