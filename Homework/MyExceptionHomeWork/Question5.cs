using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Homework.MyExceptionHomeWork
{
    //Write a program to get the value of a specified key in a HashTable and also update the value for given key.

    class Question5 
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("1", "C++");
            ht.Add("2", "C#");
            ht.Add("3", "Data Structor");
            ht.Add("4", "Java");
            ht.Add("5", "Networking");

            ICollection c = ht.Keys;
            foreach(var d in c)
            {
                Console.WriteLine(d+" "+ht[d]);
            }

            ht["1"] = "HTML";

            Console.WriteLine("Updated element list=");
            foreach (var d in c)
            {
                Console.WriteLine(d+" "+ht[d]);
            }

        }
    }
}
