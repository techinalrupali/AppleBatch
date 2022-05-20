using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.ifelse
{
    class Character
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Character");
            char ch = Convert.ToChar(Console.ReadLine());

            if((ch>='a' && ch<='z') || (ch>='A' && ch<='Z'))
                Console.WriteLine("It is Alphabet");
            else if((ch>='0'&& ch<='9'))
                Console.WriteLine("It is Digits");
            else
                Console.WriteLine("Special Character");
        }
    }
}
