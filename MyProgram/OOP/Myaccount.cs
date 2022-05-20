using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.OOP
{
    class Myaccount
    {
        long account_no;
        string acc_name;
        string branch;
        string bank_name;

        public long AccountNo
        {
            get { return account_no; }
            set { account_no = value; }
        }
        public string AccountName
        {
            get { return acc_name; }
            set { acc_name = value; }
        }
        public string Branch
        {
            get { return branch; }
            set { branch = value; }
        }
        public string BankName
        {
            get { return bank_name; }
            set { bank_name = value; }
        }
    }
    class MyaccountTest
    {
        static void Main(string[] args)
        {
            Myaccount acc = new Myaccount();
            acc.AccountNo = 12457896345;
            acc.AccountName = "Rupali Birajdar";
            acc.Branch = "Solapur";
            acc.BankName = "Bank Of Maharashtra";

            Console.WriteLine(acc.AccountNo);
            Console.WriteLine(acc.AccountName);
            Console.WriteLine(acc.Branch);
            Console.WriteLine(acc.BankName);
            
        }
    }
}

