using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.MyStringDemo
{
    //WAP to find longest word in the given sentence
    class Question10
    {
        static void Main(string[] args)
        {
            string s1 = "My State is Maharashtra";
            string[] words = s1.Split(" ");
            string w = "";
            int ctr = 0;
            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    w = s;
                    ctr = s.Length;
                }
            }
            Console.WriteLine(w);

        }
    }
}
