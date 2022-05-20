using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.MyExceptionHomeWork
{
    class Question3
    {
        static int potential(string s)
        {
            int sum = 0;
            int a;
            for(int j=0;j<s.Length;j++)
            {
                if(s[j]>='A'&& s[j]<='Z')
                {
                    a = s[j] - 64;
                    sum = sum + a;
                }
            }
            return sum;

        }
        static void Main(string[]args)
        {
            string s = Console.ReadLine();
            s = s.ToUpper();
            string[] arr = s.Split();
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=0;j<arr.Length-1;j++)
                {
                    if (potential(arr[j]) > potential(arr[j + 1]))
                    {
                        string t = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = t;
                    }
                }
            }
            foreach(string wrd in arr)
                Console.WriteLine(wrd+" ");
            Console.ReadLine();
        }
    }
}
