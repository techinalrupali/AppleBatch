using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject.HomeWork1
{
    //count the number of words in the string
    class Question2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Sentence:");
            string str = Console.ReadLine();
            Console.WriteLine("Enter word to search:");
            string wrd = Console.ReadLine();
            string[] arr = str.Split(" ");
            int c = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == wrd)
                    c++;
            }
            Console.WriteLine("count=" + c);
        }

    }
}
