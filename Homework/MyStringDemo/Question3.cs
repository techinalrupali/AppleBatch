using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.MyStringDemo
{
    //WAP to count occurrences of a character in given string
    class Question3
    {
        static void Main(string[] args)
        {
            string s1 = "website";
            Console.WriteLine("string:"+s1);

            while (s1.Length > 0)
            {
                Console.WriteLine(s1[0] + " = ");
                int cal = 0;
                for (int i=0;i<s1.Length;i++)
                {
                    
                    if (s1[0] == s1[i])
                    {
                        cal++;
                    }
                }
                
                Console.WriteLine(cal);
                s1 = s1.Replace(s1[0].ToString(),string.Empty);
             }
            Console.ReadLine();
            

        }
    }
}
