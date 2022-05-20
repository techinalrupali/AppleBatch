using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.OOP
{
    class Bankaccount
    {
        long account_no;
        string acc_name;
        string branch;
        string bank_name;

        public Bankaccount(long acc_no,string aname)
        {
            Console.WriteLine("It is 1st para");
            account_no = acc_no;
            acc_name = aname;
        }
        public Bankaccount(long acc_no,string aname,string br):this(acc_no,aname)
        {
            Console.WriteLine("It is 2nd para");
            branch = br;
        }
        public Bankaccount(long acc_no, string aname, string br,string bank_n):this(acc_no,aname,br)
        {
            Console.WriteLine("It is 3rd para");
            bank_name = bank_n;
        }
        static void Main(string[] args)
        {
            Bankaccount ba = new Bankaccount(1234568596, "Rupali", "Solapur", "SBI");
        }
    }
}
