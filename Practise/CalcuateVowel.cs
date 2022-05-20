using System;
using System.Collections.Generic;
using System.Text;

namespace Practise
{
    class CalcuateVowel
    {
        static void Main(string[] args)
        {
            string s1 = "Rupali Birajdar";
            char[] s2 = s1.ToCharArray();
            int vcount = 0;
            int conscount = 0;
            for(int j=0;j<s2.Length;j++)
            {
                if(s2[j]=='a'||s2[j]=='e'||s2[j]=='i'||s2[j]=='o'||s2[j]=='u'||s2[j] == 'A' || s2[j] == 'E' || s2[j] == 'I' || s2[j] == 'O' || s2[j] == 'U')
                {
                    vcount++;
                }
                else
                {
                    conscount++;
                }
            }
            Console.WriteLine("Vowel in the string:"+vcount);
        }
    }
}
