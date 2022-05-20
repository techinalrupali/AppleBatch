using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject
{
    class Demo
    {
        static void Main(string[] args)
        {
            string s1 = " abcedf";
            string s2 = " cg";
            int c = 0;
            bool isPresent = false;
            for(int i=0;i<s1.Length;i++)
            {
             
                for(int j=0;j<s2.Length;j++)
                {
                    if (s1[i] == s2[j])
                        isPresent=true;
                }
                if(!isPresent)
                {
                    Console.WriteLine("Yes String found");
                    c++;
                }
            }
            if(c==0)
            {
                Console.WriteLine("Given string is found");

            }
           else
            {
                Console.WriteLine("Not found");
            }
            c = 0;
        }
    }
}
