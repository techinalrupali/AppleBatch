using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Test
{
    //Red Blue
    class RedBlue
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=100;i++)
            {
                if(i%3==0 && i%5==0)
                    Console.WriteLine("RedBlue");
                else if(i%3==0)
                    Console.WriteLine("Red");
                else
                    Console.WriteLine("Blue");
            }
        }
    }
}
