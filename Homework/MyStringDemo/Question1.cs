using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.MyStringDemo
{
    //WAP and make use of all string functions in it.
    class Question1
    {
        static void Main(string[] args)
        {
            string s1 = "Rupali Birajdar";
            Console.WriteLine(s1);
            Console.WriteLine("Upper Case="+s1.ToUpper());
            Console.WriteLine("Lower Case="+s1.ToLower());
            Console.WriteLine("Length="+s1.Length);
            Console.WriteLine("Index of="+s1.IndexOf("a"));
            Console.WriteLine("Last Index of="+s1.LastIndexOf("j"));
            Console.WriteLine("Remove name="+s1.Remove(9));
            Console.WriteLine("Replace name="+s1.Replace('i','e'));
            Console.WriteLine("Substring="+s1.Substring(4,5));
            Console.WriteLine("Trim="+s1.Trim());
        }
    }
}
