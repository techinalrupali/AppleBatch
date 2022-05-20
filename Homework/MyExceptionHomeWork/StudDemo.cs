using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Homework.MyExceptionHomeWork
{
    class student:IComparable
    {
        string name;
        int percent;
        string city;

        public student(string name, int percent, string city)
        {
            this.Name = name;
            this.Percent = percent;
            this.City = city;
        }
        public int CompareTo(object o)
        {
            student s2 = (student)o;
            if (city.CompareTo(s2.city) == 0)
                return name.CompareTo(s2.name);
            else
                return city.CompareTo(s2.city);
        }
        public override string ToString()
        {
            return $"Name:={name} City={city} Percent={percent}";
        }

        public string Name { get => name; set => name = value; }
        public int Percent { get => percent; set => percent = value; }
        public string City { get => city; set => city = value; }
    }
    class StudDemo
    {
        static void Main(string[] args)
        {
            SortedList s1 = new SortedList();
            s1.Add(new student("Tina", 80, "Pune"), "Java");
            s1.Add(new student("Mina", 90, "Solapur"), "C#");
            s1.Add(new student("Ram", 92, "Mumbai"), "Java");
            s1.Add(new student("Maya", 85, "Pune"), "HTML");
            s1.Add(new student("Priya", 92, "Solapur"), "CSS");

            foreach(DictionaryEntry d in s1)
                Console.WriteLine(d.Key+" "+d.Value);

        }
    }
}
