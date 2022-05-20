using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject.HomeWork1
{
    //WAP to find total number of alphabets,digits or special character
    class Question5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            int i=0;
            int alpha = 0;
            int digit = 0;
            int schar = 0;
            int l = str.Length;
            while(i<l)
            {
                if((str[i]>='a'&& str[i]<='z')||(str[i]>='A'&&str[i]<='Z'))
                {
                    alpha++;
                }    
                else if(str[i]>='0' && str[i]<='9')
                {
                    digit++;
                }
                else
                {
                    schar++;
                }
                i++;
            }
            Console.WriteLine("Alphabets are:"+alpha);
            Console.WriteLine("digts are:" + digit);
            Console.WriteLine("Special character are:"+schar);

        }
    }
}
