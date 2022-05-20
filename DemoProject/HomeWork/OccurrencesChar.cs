using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject.HomeWork
{
    //Occurrences of each char element from the char array
    class OccurrencesChar
    {
        static void Main(string[] args)
        {
            string r = "GoodMorning";
            char[] ch = r.ToCharArray();
            int c = 0;
            for(int i=0;i<ch.Length;i++)
            {
                for(int j=0;j<ch.Length;j++)
                {
                    if (ch[i] == ch[j] && j < i)
                        break;
                    if (ch[i] == ch[j])
                        c++;

                }
                if(c!=0)
                    Console.WriteLine($"Occurrences of each char {ch[i]} is {c}");
                c = 0;
            }
        }
    }
}
