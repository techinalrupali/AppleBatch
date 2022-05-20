using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject
{
    class LeftTrim
    {
        static void Main(string[] args)
        {
            string s = "  Rupali ";
            string s1 = s.TrimStart();
            Console.WriteLine(s1);

        }
    }
}
