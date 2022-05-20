using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject.Test
{
    class Ques4
    {
        static void Main(string[] args)
        {
            int c = 0;
            string s1 = Console.ReadLine();
            string search = Console.ReadLine();
            string[] a = s1.Split(" ");
            
            for (int i=0;i<a.Length;i++)
            {
                if (a[i] == search)
                {
                    c++;
                }
            }
            Console.WriteLine(c);
        }
    }
}
