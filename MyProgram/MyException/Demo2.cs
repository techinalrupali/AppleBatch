using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.MyException
{
    class NullExceptionDemo
    {
        static void Main(string[] args)
        {
            string str=null;
            try
            {
                Console.WriteLine(str[7]);
            }
            catch(NullReferenceException n)
            {
                Console.WriteLine(n.Message);
            }
        }
    }


    class MultipleExceptionDemo
    {
        static void Main(string[] args)
        {

            try
            {
                
                Console.WriteLine("Enter the number:");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Divide=" + (a / b));
                string s = "Meera";
                Console.WriteLine(s[5]);
            }
            catch (DivideByZeroException d)
            {
                Console.WriteLine(d.Message);
            }

            catch (FormatException f)
            {
                Console.WriteLine(f.Message);
            }
            catch(IndexOutOfRangeException r)
            {
                Console.WriteLine(r.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    class UserDefinedDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Username and Password:");
            string uname = Console.ReadLine();
            string pass = Console.ReadLine();
            if (uname == "Admin" && pass == "*****")
            {
                Console.WriteLine("Welcome");
                Console.WriteLine("User Login Successfully...!!!");
            }
            else
            {
                throw new InvalidLoginException("Enter Your correct username and password");
            }
        }
    }

    class InvalidLoginException:ApplicationException
    {
        public InvalidLoginException(string s):base(s)
        {

        }
    }
}
