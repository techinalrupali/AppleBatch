using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Test
{
    class Trimorphic
    {
        static void Main(string[] args)
        {
            int i, cube, n, x = 0;
            Console.WriteLine("Enter the number:");
            i = Convert.ToInt32(Console.ReadLine());
            cube = i * i * i;
            Console.WriteLine("Cube:"+cube);
            n = i;
            while(n>0)
            {
                x++;
                n = n / 10;
            }
            int end = cube %(int) Math.Pow(10, x);
            if(i==end)
            {
                Console.WriteLine("It is Trimorphic:"+i);
            }
            else
            {
                Console.WriteLine("It is not Trimorphic:"+i);
            }













        }
    }
}
