using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.ifelse
{
    class VowelConsonant
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Alphabets:-");
            char ch = Convert.ToChar(Console.ReadLine());

            if(ch=='a')
                Console.WriteLine("It is Vowel");
            else if(ch=='e')
                Console.WriteLine("It is Vowel");
            else if(ch=='i')
                Console.WriteLine("It is Vowel");
            else if(ch=='o')
                Console.WriteLine("It is Vowel");
            else if(ch=='u')
                Console.WriteLine("It is Vowel");
            else
                Console.WriteLine("It is Consonant");
        }
    }
}
