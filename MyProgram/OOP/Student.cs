using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.OOP
{
    class Student
    {
        int age;
        string name;
        float percent;

        public void setage(int a)
        {
            age = a;
        }
        public int getage()
        {
            return age;
        }

        public void setname(string n)
        {
            name = n;
        }
        public string getname()
        {
            return name;
        }
        public void setpercent(float p)
        {
            percent = p;
        }
        public float getpercent()
        {
            return percent;
        }
    }

    class Scope
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Console.WriteLine("Enter the age:");
            int a = Convert.ToInt32(Console.ReadLine());
            s1.setage(a);

            Console.WriteLine("Enter the name:");
            string n = Console.ReadLine();
            s1.setname(n);

            Console.WriteLine("Enter the percent:");
            float p = Convert.ToSingle(Console.ReadLine());
            s1.setpercent(p);

            Console.WriteLine("Age="+s1.getage());
            Console.WriteLine("Name="+s1.getname());
            Console.WriteLine("Percent="+s1.getpercent());



        }

    }

}
