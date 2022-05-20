using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.ArrayHomework
{
    class stringQuestion3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string s1 = Console.ReadLine();
            string s2 = s1.Replace(" "," ");
            StringBuilder sb = new StringBuilder();
            for(int i=s2.Length-1;i>=0;i--)
            {
                sb.Append(s2[i]);
            }
            for(int i=0;i<s1.Length;i++)
            {
                if(s1[i]==' ')
                {
                    sb.Insert(i," ");
                }
            }
            Console.WriteLine(sb);
        }

       
    }
}
