using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject.Test
{
    class Ques1
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char ch;
            for(int i=0;i<s.Length;i++)
            {
                if(s[i]>='A'&& s[i]<='Z')
                {
                    ch =(char) (s[i] + 32);
                    Console.Write(ch);
                }
                else if (s[i] >= 'a' && s[i] <= 'z')
                {
                    ch = (char)(s[i] - 32);
                    Console.Write(ch);
                }
                else
                {
                    Console.Write(s[i]);
                }


            }
            Console.WriteLine();
        }
    }
}
