using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.OOP
{
    class MyAccount12
    {
        public long AccountNo;
        public string CustomerName;


        public MyAccount12()
        {
            AccountNo = 253874962174;
            CustomerName = "Rupali Birajdar";
            Console.WriteLine("I am in default Constructor");
        }
        public MyAccount12(long accno, string cusname)
        {
            AccountNo = accno;
            CustomerName = cusname;
            Console.WriteLine("I am in paramerterized Constructor");
        }

    }
    internal class MyAccount
    {
        static void Main(string[] args)
        {
            MyAccount12 a11 = new MyAccount12();
            MyAccount12 a12 = new MyAccount12(45896742326,"Rita");
        }
    }
}
