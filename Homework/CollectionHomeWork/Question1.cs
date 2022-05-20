using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Homework.CollectionHomeWork
{
    class Question1
    {
        static void Main(string[] args)
        {
            List<string> l1= new List<string>();
            l1.Add("C");
            l1.Add("D");
            l1.Add("V");
            l1.Add("A");
            l1.Add("M");
            Console.WriteLine("Before the Sort List:");
            foreach(string d in l1)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine("After the Sort List:");
            l1.Sort();
            foreach(string d in l1)
            {
                Console.WriteLine(d);
            }
        }
    }
}
