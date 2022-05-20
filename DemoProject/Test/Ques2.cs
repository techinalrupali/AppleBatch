using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject.Test
{
    class Ques2
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

            char[] a1 = s1.ToCharArray();
            char[] a2 = s2.ToCharArray();
            Array.Sort(a1);
            Array.Sort(a2);

            string ss1 = string.Join(" ", a1);
            string ss2 = string.Join(" ", a2);

            if(ss1==ss2)
                Console.WriteLine("Anagram");
            else
                Console.WriteLine("Not Anagram");


        }
    }
}
