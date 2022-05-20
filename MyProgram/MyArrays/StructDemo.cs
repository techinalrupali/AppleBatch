using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.MyArrays
{
    struct student
    {
        public int id;
        public string name;

        public student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

    }
    class studentDemo
    {
        static void Main(string[] args)
        {
            student s11 = new student();
            s11.id = 101;
            s11.name = "Rupali";
            Console.WriteLine(s11.id);
            Console.WriteLine(s11.name);
        }
    }
}
