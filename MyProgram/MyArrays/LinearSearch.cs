using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.MyArrays
{
    class LinearSearch
    {
        static void Main(string[] args)
        {
            int[] a = { 10, 5, 8, 3, 44, 7, 6, 90 };
            Console.WriteLine("Enter search element");
            int search = int.Parse(Console.ReadLine());
            int flag = 0;
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]==search)
                {
                    Console.WriteLine("Element found at position"+i);
                    flag = 1;
                }
            }
            if(flag==0)
                Console.WriteLine("Not Present");
        }
    }
}
