using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Homework.CollectionHomeWork
{
    class Question3
    {
        static void Main(string[] args)
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("Pink");
            q.Enqueue("Yellow");
            q.Enqueue("Black");
            q.Enqueue("White");
            q.Enqueue("Red");

            q.Dequeue();
            foreach(string d in q)
                Console.WriteLine(d);
        }
    }
}
