using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Array
{
    class SearchElement
    {
        static void Main(string[] args)
        {
            int i, search, x;
            Console.WriteLine("Enter Size:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            for (i = 0; i < size; i++)
            {
                Console.WriteLine("Enter the elements:");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Please enter the search element:");
            search = Convert.ToInt32(Console.ReadLine());

            x = 0;
            for(i=0;i<size;i++)
            {
                if(a[i]==search)
                {
                    x = 1;
                    break;
                }
            }
            if(x==1)
                Console.WriteLine("Number is present in Array= " +search+" "+"Position="+(i+1));
            else
                Console.WriteLine("Number is not present in Array");
        }
    }
}
