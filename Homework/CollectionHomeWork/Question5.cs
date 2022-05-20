using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Homework.CollectionHomeWork
{
    class Question5
    {
        static void Main(string[] args)
        {
            SortedList s1 = new SortedList();
            s1.Add(1, "One");
            s1.Add(3, "Three");
            s1.Add(2, "Two");
            s1.Add(5, "Five");
            s1.Add(4, "Four");
            

            foreach(DictionaryEntry d in s1)
                Console.WriteLine(d.Key+" "+d.Value);
        }
    }
}
