using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.ifelse
{
    class SimpleCalculator
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            Console.WriteLine("Enter Two Numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1.Addition 2.Substraction 3.Multiplication 4.Division");
            Console.WriteLine("Enter your choice:");
            int ch = Convert.ToInt32(Console.ReadLine());

            if (ch == 1)
            {
                result = num1 + num2;
                Console.WriteLine("Addition:" + result);
            }
            else if(ch==2)
            {
                result = num1 - num2;
                Console.WriteLine("Substraction:" + result);
            }
            else if(ch==3)
            {
                result = num1 * num2;
                Console.WriteLine("Multiplication:"+result);
            }
            else if(ch==4)
            {
                result = num1 / num2;
                Console.WriteLine("Division:"+result);
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
        }
    }
}
