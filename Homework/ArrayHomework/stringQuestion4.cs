using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.ArrayHomework
{
    class stringQuestion4
    {
        static void Main(string[] args)
        {
            string s1 = "Hi how are you students";
            StringBuilder sb = new StringBuilder();
            
                string word = " ";
                for (int  i = 0; i < s1.Length; i++)
                {
                    if (s1[i] != ' ')
                        word += s1[i];
                    else
                    {
                        for ( i = s1.Length - 1; i >= 0; i--)
                        {
                            sb.Append(s1[i]);
                        }
                        word = " ";

                    }
                }
                Console.WriteLine(word+" "); 
            
        }
    }
}
