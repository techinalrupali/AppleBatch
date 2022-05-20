using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject.Test
{
    class Ques5
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int c = 0;
            for(int i=1;i<=a;i++)
            {
                if(a%i==0)
                {
                    c++;
                }
            }
            if(c==2)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}
