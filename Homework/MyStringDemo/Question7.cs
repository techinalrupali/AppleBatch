using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.MyStringDemo
{
    //WAP to check whether given string is palindrome or not.
    class Question7
    {
        static void Main(string[] args)
        {
            string s1 = new string("nitin");
            string rev = "";
            for(int i=s1.Length-1;i>=0;i--)
            {
                rev = rev + s1[i];
            }
            if(rev==s1)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");
        }
    }
}
