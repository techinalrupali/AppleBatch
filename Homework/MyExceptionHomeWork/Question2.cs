using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Homework.MyExceptionHomeWork
{
    //Sort Arraylist of String in reverse order of its natural sorting.
    class Question2
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Ram");
            al.Add("Tina");
            al.Add("Pihu");
            al.Add("Sam");
            al.Add("Meera");
            Console.WriteLine("Before the list=");
            foreach (var d in al)
            {
                Console.WriteLine(d);
            }

            //after sorting
            al.Sort();
            //then sorting list in reverse order
            al.Reverse();

            Console.WriteLine("After the list=");
            foreach(var d in al)
            {
                Console.WriteLine(d);
            }
        }
    }
}
