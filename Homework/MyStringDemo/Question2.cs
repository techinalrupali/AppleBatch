using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.MyStringDemo
{
    //WAP To find first occurrence of a character in a given string
    class Question2
    {
        static void Main(string[] args)
        {
            string s1 = "Rupali Birajdar";
            int dd = s1.IndexOf('i');
            Console.WriteLine(dd);
        }
    }
}
