using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject.HomeWork
{
    class LongestWord
    {
        static void Main(string[] args)
        {
            string s1  = "India is my Country";
            string[] w = s1.Split(' ');
            int len = w.Length;
            int max = 0;
            int ni = 0;
            for(int i=0;i<len;i++)
            {
                if(s1[i]>max)
                {
                    max = w[i].Length;
                    ni = i;

                }
            }
            Console.WriteLine("Longest String:"+w[ni]);




        }
    }
}
