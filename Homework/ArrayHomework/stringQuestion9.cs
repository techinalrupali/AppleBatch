using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.ArrayHomework
{
    class stringQuestion9
    {
        static void Main(string[] args)
        {
            string[] arr = { "winter", "fall", "summer", "spring" };
            string word = " ";
            for(int i=0;i<arr.Length;i++)
            {
                string n = arr[i];
                for(int j=i;j<n.Length;j++)
                {
                    word = word + n[j];
                    break;
                }
            }
            Console.WriteLine(word);
        }
    }
}
