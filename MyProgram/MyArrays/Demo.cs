using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.MyArrays
{
    class student1 
    {
        string name;
        int per;

        public student1(string name, int per)
        {
            this.name = name;
            this.per = per;
           
        }
        public override string ToString()
        {
            return $"Name:{name} percent:{per}";
        }
    }
    class Demo
    {

        static void Main(string[] args)
        {
            string nm;
            int per;
            student1[] s1 = new student1[3];
            for (int i = 0; i < s1.Length; i++)
            {
                Console.WriteLine("Enter the name,percentage:");
                nm = Console.ReadLine();
                per = int.Parse(Console.ReadLine());
                s1[i] = new student1(nm, per);


            }
            for (int i = 0; i < s1.Length; i++)
            {
                Console.WriteLine(s1[i]);
            }
        }
    }
}
