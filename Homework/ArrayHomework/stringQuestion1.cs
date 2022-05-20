using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.ArrayHomework
{
    internal class stringQuestion1
    {
       public string Ispalindrome(string s1)
        {
            string rev = "";
            for(int i=s1.Length-1;i>=0;i--)
            {
                rev = rev + s1[i];

            }
            return rev;
        }
       internal static void Main(string[] args)
        {
            string s1 = "radar , noon , repaper , wow , level";
            string[] arr = s1.Split(" ");
            int x = 0;
            stringQuestion1 sq = new stringQuestion1();
            string larg = "";
            for(int i=0;i<arr.Length;i++)
            {
                if(sq.Ispalindrome(arr[i])==arr[i])
                {
                    if(x<arr[i].Length)
                    {
                        x = arr[i].Length;
                        larg = arr[i];
                    }
                }
            }
            Console.WriteLine(larg);
           

        }
    }
}
