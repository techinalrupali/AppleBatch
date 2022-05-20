using System;
using System.Collections.Generic;
using System.Text;

namespace Practise
{
    class TwoStringEqualorNot
    {
        static void Main(string[] args)
        {
            string p1 = Console.ReadLine();
            string p2 = Console.ReadLine();

            char[] s1 = p1.ToCharArray();
            char[] s2 = p2.ToCharArray();
            Array.Sort(s1);
            Array.Sort(s2);

            string a1 = string.Join(" ", s1);
            string a2 = string.Join(" ", s2);
            
            if(a1==a2)
                Console.WriteLine("Anagram");
            else
                Console.WriteLine("Not Anagram");
        }
    }
}
