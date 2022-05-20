using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.switchcase
{
    class SimpleCalculator
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            Console.WriteLine("Enter two Number:-");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1.Addition 2.Substraction 3.Multiplication 4.Division");
            Console.WriteLine("Enter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            { 
                case 1: 
                       result = num1 + num2;
                       Console.WriteLine("Addition="+result);
                       break;

                case 2:
                    result = num1 - num2;
                    Console.WriteLine("Substraction=" + result);
                    break;

                case 3:
                    result = num1 * num2;
                    Console.WriteLine("Multiplication=" + result);
                    break;

                case 4:
                    result = num1 / num2;
                    Console.WriteLine("Division=" + result);
                    break;

                default: 
                    Console.WriteLine("Invalid Choice");
                    break;


            }
        }
    }
}
