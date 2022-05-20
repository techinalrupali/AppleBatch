using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Array
{
    //insert an element in a specific position into an array
    class Program7
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int pos = 0;
            int item = 0;
            Console.WriteLine("Enter the number:");
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("Element["+(i+1)+"]:");
                arr[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Enter position:");
            pos = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter new item:");
            item = int.Parse(Console.ReadLine());

            for(int i=5;i>=pos;i--)
            {
                arr[i] = arr[i - 1];

            }
            arr[pos - 1] = item;
            Console.WriteLine("After elements are:");
            for(int i=0;i<6;i++)
            {
                Console.WriteLine("Element[" + (i + 1) + "]:"+arr[i]);
            }
            Console.WriteLine();

        }
    }
}
