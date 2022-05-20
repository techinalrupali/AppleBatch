using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.MyException
{
    class Demo1
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Main starts");
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Divide="+(a/b));
                Console.WriteLine("Try End");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("divide by Zero");
            }
            catch(FormatException)
            {
                Console.WriteLine("Enter the number");
            }
            catch(Exception)
            {
                Console.WriteLine("error");
            }
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine("Welcome");
            }
        }
    }


    class MyMoblie
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the moblie number:");
            long num = long.Parse(Console.ReadLine());
     
            if (num.ToString().Length== 10)
                Console.WriteLine("Valid number");

            else
            {
                try
                {
                    throw new InvalidMobileException("Number is valid for 10 digit");
                }
                catch (InvalidMobileException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        class InvalidMobileException : ApplicationException
        {
            public InvalidMobileException(string n) : base(n)
            {

            }
        }
    }
}
