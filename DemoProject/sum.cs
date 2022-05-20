using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject
{
    class sum
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count;
            input = input.ToLower();
            string[] s2 = input.Split(' ');
            for (int i = 0; i < s2.Length; i++)
            {
                count = 1;
                for (int j = i + 1; j < s2.Length; j++)
                {
                    if (s2[i].Equals(s2[j]))
                    {
                        count++;
                        s2[j] = "0";


                    }
                }

                if(count>1&&s2[i]!="0")
                    Console.WriteLine(s2[i]);

            }

        }
    }
}
