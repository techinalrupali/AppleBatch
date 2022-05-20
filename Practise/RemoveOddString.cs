using System;
using System.Collections.Generic;
using System.Text;

namespace Practise
{
    class RemoveOddString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the character");
            string s =Console.ReadLine();
            for(int i=0;i<s.Length;i++)
            {
                if (i % 2 == 1)
                {
                    s.Remove(0);
                    break;
                }
            }
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s);
            }
        }
    }
}
