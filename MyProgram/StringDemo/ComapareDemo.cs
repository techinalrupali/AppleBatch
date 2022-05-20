using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.StringDemo
{
    class comaparestringDemo 
    {
        static void Main(string[] args)
        {
            string[] s1 = { "Om", "Piya", "Riya", "tiya", "Maya" };
            for(int i=0;i<s1.Length-1;i++)
            {

                for (int j = 0; j < s1.Length - 1-i; j++)
                {
                    if (s1[j].CompareTo(s1[j + 1]) == 1)
                    {

                        string temp = s1[j];
                        s1[j] = s1[j + 1];
                        s1[j + 1] = temp;
                    }
                }
            }
            foreach(string d in s1)
                Console.Write(d+" ");
        }

    }
}
