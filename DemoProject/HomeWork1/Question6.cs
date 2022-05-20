using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject.HomeWork1
{
    //Uppercase to Lowercase
    class Question6
    {
        static void Main(string[] args)
        {
            String s1 = "ABCDEFGH";
            Console.WriteLine("Upper the string:"+s1);
            string s2 = s1.ToLower();
            Console.WriteLine("Lower the string:"+s2);
        }
    }
}
