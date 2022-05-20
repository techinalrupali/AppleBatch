using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject
{
    class Student
    {
        string sname;

        public Student(string sname)
        {
            this.Sname = sname;
        }

        public string Sname { get => sname; set => sname = value; }
    }
    class course
    {
        string coursename;
        Student[] s1 = new Student[10];

        public course(string coursename, Student[] s1)
        {
            this.Coursename = coursename;
            this.S1 = s1;
        }

        

        public string Coursename { get => coursename; set => coursename = value; }
        internal Student[] S1 { get => s1; set => s1 = value; }
    }

    class CourseTest
    {
        static void Main(string[] args)
        {
            Student[] s1 = new Student[]
            {
                new Student("Ram"),
                new Student("Tiya"),
                new Student("Maya"),
                new Student("siya"),
                new Student("Riya"),
                new Student("Priya"),
                new Student("Meera"),
                new Student("Rani"),
                new Student("pihu"),
                new Student("Ashu"),
            };

            course c = new course("C#", s1);
            for(int i=0;i<=10;i++)
                Console.WriteLine(c.S1[i].Sname);
        }
    }
}
