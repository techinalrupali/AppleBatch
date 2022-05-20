using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject
{
    class fibonacci
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number elements");
            int num = Convert.ToInt32(Console.ReadLine());
            int n1 = 0, n2 = 1;
            int sum;
            for (int i = 1; i < num; i++)
            {
                Console.WriteLine(n1);
                sum = n1 + n2;
                n1 = n2;
                n2 = sum;
                
            }
            Console.WriteLine(n1);

        }
    }
}
