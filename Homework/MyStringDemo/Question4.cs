using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.MyStringDemo
{
    //WAP to trim leading white space charaters in a string.
    class Question4 
    {
        static void Main(string[] args)
        {
            string s1 = "  Rupali Birajdar   ";
            string dd = s1.Trim();
            Console.WriteLine("Name="+dd);
        }
    }
}
