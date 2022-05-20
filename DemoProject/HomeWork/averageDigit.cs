using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject.HomeWork
{
    class averageDigit
    {
        static void Main(string[] args)
        {
            string s1 = "India2433";
            int sum = 0;
            int c = 0;
            int avg = 0;
          
            for(int i=0;i<s1.Length;i++)
            {
                if ((s1[i] >= '0') && (s1[i] <= '9'))
                {
                    Console.WriteLine(s1[i]);
                    sum = sum + (s1[i]-'0');
                    c++;


                }
            }
            avg = sum /c;
            Console.WriteLine("Sum of Digit in string:"+sum);
            Console.WriteLine("Average of Digit in string:" + avg);
        }
        
    }
}
