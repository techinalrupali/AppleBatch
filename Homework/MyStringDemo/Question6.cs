using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.MyStringDemo
{
    //WAP to find first occurrence of a word in a given string
    class Question6
    {
        static void Main(string[] args)
        {
            string s1 = "India is my country";
            int dd = s1.IndexOf("my");
            Console.WriteLine(dd);
        }
    }
}
