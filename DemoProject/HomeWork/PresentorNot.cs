using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject.HomeWork
{
    //given element present in array or not
    class PresentorNot
    {
        static void Main(string[] args)
        {
            int[] a = { 8, 5, 4, 6, 7, 3, 9, 10, 2 };
            foreach(int d in a)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine("Enter the Element:");
            int b = Convert.ToInt32(Console.ReadLine());
            bool isPresent = false;
            {
                for(int i=0;i<a.Length;i++)
                {
                    if (a[i] == b)
                        isPresent = true;
                }
                if(isPresent==true)
                    Console.WriteLine("Element is present");
                else
                    Console.WriteLine("Element is not Present");
            }

        }
    }
}
