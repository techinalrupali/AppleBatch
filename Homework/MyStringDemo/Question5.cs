using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.MyStringDemo
{
    //WAP to count total number of words in a string
    class Question5
    {
        static void Main(string[] args)
        {
            string s1 = "My Name is Rupali Birajdar";
            int l = 0;
            int wrd = 1;
            while(l<=s1.Length-1)
            {
                if(s1[l] ==' ')
                {
                    wrd++;
                }
                l++;
            }
            Console.WriteLine(s1);
            Console.WriteLine("Total number of word in string:"+wrd);
        }
        
        
    }
}
