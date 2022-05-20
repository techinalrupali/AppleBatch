using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.MyArrays
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            int[] a = { 25,10, 63, 74, 58, 96,45 };
            Console.WriteLine("Enter Search Element:");
            int search = int.Parse(Console.ReadLine());
            int start = 0, end = a.Length - 1;
            int flag = 0;
            while(start<=end)
            {
                int mid = (start + end)/2;
                if(a[mid]==search)
                {
                    Console.WriteLine("Element found at pos:"+mid);
                    flag = 1;
                    break;

                }
                else if(search>a[mid])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
                foreach (int d in a)
                    Console.Write(d + " ");
            }
            
        }
    }
}
