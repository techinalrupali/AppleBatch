using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject.HomeWork1
{
    //Reverse array
    class Question7
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 90, 45, 29, 37, 78 };
            
            int j = arr.Length - 1;
            Console.WriteLine("Reverse array:");
            for(int i=0;i<arr.Length/2;i++)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                j--;
            }
            foreach(int d in arr)
                Console.WriteLine(d);
        }
    }
}
