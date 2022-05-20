using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject.HomeWork1
{
    //repalce all the 0's with 1's in your array
    class Question10
    {
        static void Main(string[] args)
        {
            int[] a = { 26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34 };
            int num = 0;
            int x = a.Length;
            if (x == 0)
                num = 1;
            else
            {
                int temp = 0;
                while (x > 0)
                {
                    int rem = x % 10;
                    if (rem == 0)
                        rem = 1;

                    temp = temp * 10 + rem;
                    num = num / 10;

                }
                num = 0;

                Console.WriteLine("Converting array:" + num);


            }   
        }
    }
}
