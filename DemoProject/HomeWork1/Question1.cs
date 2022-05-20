using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject.HomeWork1
{
    //duplicate words
    class Question1
    {
        static void Main(string[] args)
        {
            string s1 = "my name is abc and my brother name is xyz";
            int count=0;
            s1 = s1.ToLower();
            string[] s2 = s1.Split(' ');
            for(int i=0;i<s2.Length;i++)
            {
               
                for(int j=0;j<s2.Length;j++)
                { 
                    if (s2[i]==s2[j]&& j<i)
                    {
                        break;

                    }
                
                    else if (s2[i]==s2[j])
                    {
                        count++;
                       
                    }
                }
                if (count > 1 )
                    Console.WriteLine(s2[i]+"= Frequency is:"+count);
                count = 0;
            } 
           
        }
    }
}
