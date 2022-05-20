using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.StringDemo
{
    class Password
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Password:");
            string pass = Console.ReadLine();
            int cUpper = 0;
            int cLower = 0;
            int cSymbol = 0;
            int cDigit = 0;
            if (pass.Length < 5)
            {
                Console.WriteLine("Password is at least 5");
            }
            else
            {
                char[] c = pass.ToCharArray();
                for (int i = 0; i < c.Length; i++)
                {
                    if ((c[i] >= 'A' && c[i] <= 'Z'))
                    {
                        cUpper++;
                    }
                    else if (c[i] >= 'a' && c[i] <= 'z')
                    {
                        cLower++;
                    }
                    else if (c[i] >= '0' && c[i] <= '9')
                    {
                        cDigit++;
                    }
                    else
                    {
                        cSymbol++;
                    }
                }
                if (cUpper == 0)
                    Console.WriteLine("please enter upper case character");
                else if (cLower == 0)
                    Console.WriteLine("Please enter Lower case character");
                else if (cDigit == 0)
                    Console.WriteLine("Please enter Digit ");
                else if (cSymbol == 0)
                    Console.WriteLine("Please enter Symbol ");
            }
        }
    }
}
