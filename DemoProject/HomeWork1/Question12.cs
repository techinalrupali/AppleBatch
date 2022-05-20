using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject.HomeWork1
{
    // find min character
    class Question12
    {
        static void Main(string[] args)
        {
            char[] ch = { 'A', 'D', 'E', 'x', 'z', 'R' };
            foreach(char d in ch)
            {
                Console.WriteLine(d);
            }
            char min = ch[0];
            for(int i=0;i<ch.Length-1;i++)
            {
                if (min > ch[i])
                    min = ch[i];
            }
            Console.WriteLine("Min char="+min);

        


        }
    }
}
