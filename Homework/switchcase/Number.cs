using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.switchcase
{
    class Number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 1 to 5");
            int a = Convert.ToInt32(Console.ReadLine());

            switch(a)
            {
                case 1:
                    Console.WriteLine("One");
                    break;

                case 2:
                    Console.WriteLine("Two");
                    break;

                case 3:
                    Console.WriteLine("Three");
                    break;

                case 4:
                    Console.WriteLine("Four");
                    break;

                case 5:
                    Console.WriteLine("Five");
                     break;

                default:
                    Console.WriteLine("Not a digits");
                    break;



            }

        }
    }
}
