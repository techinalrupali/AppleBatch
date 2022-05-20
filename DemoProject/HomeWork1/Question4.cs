using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject.HomeWork1
{
    //descending order
    class Question4
    {
        static void Main(string[] args)
        {
            string[] nm = { "riya", "piya", "maya", "siya", "tina", "pihu", "ashu", "niki", "laxmi", "vaibhi" };
            foreach(string str in nm)
            {
                Console.Write(str+" ");
            }
            for(int i=0;i<nm.Length;i++)
            {
                for(int j=i+1;j<nm.Length;j++)
                {
                    if(nm[i].CompareTo(nm[j])<0)
                    {
                        string temp = nm[i];
                        nm[i] = nm[j];
                        nm[j] = temp;
                    }
                }
            }
            Console.WriteLine();
            foreach(string str in nm)
            {
                Console.Write(str+" ");
            }
        }
        
    }
}
