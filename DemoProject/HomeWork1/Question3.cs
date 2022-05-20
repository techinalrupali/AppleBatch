using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject.HomeWork1
{
    //anagram or not
    class Question3
    {
        static void Main(string[] args)
        {
            string s1 = "racecar";
            string s2 = "carrace";

            char[] a1 = s1.ToCharArray();
            char[] a2 = s2.ToCharArray();
            Array.Sort(a1);
            Array.Sort(a2);

            string m1 = string.Join("", a1);
            string m2 = string.Join("", a2);
            
            if(m1==m2)
                Console.WriteLine("It is Anagram");
            else
                Console.WriteLine("It is not Anagram");
        }
    }
}
