using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject.HomeWork
{
    class CountVowels
    {
        static void Main(string[] args)
        {
            string s1 = "Rupali Birajdar";
            int vowel_count = 0;
            int cons_count = 0;
            for(int i=0;i<s1.Length;i++)
            {
                if (s1[i] == 'a' || s1[i] == 'e' || s1[i] == 'i' || s1[i] == 'o' || s1[i] == 'u')
                    vowel_count++;
                else
                    cons_count++;
            }
            Console.WriteLine("Vowels Elements are:"+vowel_count);
        }
    }
}
