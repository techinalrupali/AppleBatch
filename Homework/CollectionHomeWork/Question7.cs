using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Homework.CollectionHomeWork
{
    class Question7
    {
        static void Main(string[] args)
        {
            Stack moviename  = new Stack();
            moviename.Push("ABCD");
            moviename.Push("Mision Mangal");
            moviename.Push("Taqdeer");
            moviename.Push("3 Idiots");
            moviename.Push("KGF");

            moviename.Pop();
           

            foreach(string d in moviename)
                Console.WriteLine(d);
        }
    }
}
