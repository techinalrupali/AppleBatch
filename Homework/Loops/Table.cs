using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Loops
{
    class Table
    {
        static void Main(string[] args)
        {
            int i, num;
            Console.WriteLine("Enter the number:");
            num = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=10;i++)
            {
                Console.WriteLine(num + " * " + i + " = " + num * i);
            }

        }
    }
}
