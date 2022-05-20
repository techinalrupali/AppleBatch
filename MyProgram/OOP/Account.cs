using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.OOP
{
    class Account
    {
        long Acc_id;
        string Acc_Name, Branch, Bank_Name;
        int Balance = 10000;
        public void Insert()
        {
            Console.WriteLine("Enter Bank Name:");
            Bank_Name = Console.ReadLine();
            Console.WriteLine("Enter Branch:");
            Branch = Console.ReadLine();
            Console.WriteLine("Enter Account ID:");
            Acc_id = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Account Name:");
            Acc_Name = Console.ReadLine();
            Console.WriteLine();
        }
        public void Display()
        {
            Console.WriteLine("Bank Name="+Bank_Name);
            Console.WriteLine("Bank Branch="+Branch);
            Console.WriteLine("Account ID="+Acc_id);
            Console.WriteLine("Account Name="+Acc_Name);
            Console.WriteLine("Balance="+Balance);
        }
        public void Withdraw()
        {
            Console.WriteLine("Please enter your withdraw amount");
            int withdraw = Convert.ToInt32(Console.ReadLine());
            if (withdraw <= Balance)
                Balance = Balance - withdraw;
            else
                Console.WriteLine("Insufficent Balance...!");
            Console.WriteLine();
        }
        public void CheckBalance()
        {
            Console.WriteLine($"Your Balance is={ Balance}");
            Console.WriteLine();
        }
    }
    internal class BankAccount
    {
        static void Main(string[] args)
        {
            Account acc = new Account();
            acc.Insert();
            acc.Display();
            acc.Withdraw();
            acc.CheckBalance();
            Console.WriteLine("Thank You...!");

        }
    }
}
