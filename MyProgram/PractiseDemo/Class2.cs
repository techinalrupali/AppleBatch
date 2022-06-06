using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.PractiseDemo
{
    //delegate is ref type in c#, it is type,declare inside the namespace
    //singlecast delegates-single delegate hold reference of single method
    public delegate void mydelegate1(string name);
    class singlecast_dele 
    {
        public void Uppercase(string nm)
        {
            Console.WriteLine("Uppercase:"+nm.ToUpper());
        }
    }
    class singlecast_deleTest
    {
        static void Main(string[] args)
        {
            singlecast_dele s1 = new singlecast_dele();
            mydelegate1 md = new mydelegate1(s1.Uppercase);
            Delegate[] del = md.GetInvocationList();
            foreach (Delegate d in del)
            {
                Console.WriteLine(d.Method);
                d.DynamicInvoke("Maharashtra");
            }

        }
    }

    //multicast Delegates-single delegate hold reference of multiple methods.
    public delegate void mydelegate(string name);
    class Class2
    {
        public void Uppercase(string nm)
        {
            Console.WriteLine("Uppercase:"+nm.ToUpper());
        }
        public void Lowercase(string nm)
        {
            Console.WriteLine("Lowercase:"+nm.ToLower());
        }
    }
    class Class2Test
    {
        static void Main(string[] args)
        {
            Class2 c2 = new Class2();
            mydelegate mydel = new mydelegate(c2.Uppercase);
            mydel += new mydelegate(c2.Lowercase);

            mydel -= new mydelegate(c2.Uppercase);//remove the ref from the invocation list

            Delegate[] list = mydel.GetInvocationList();
            foreach(Delegate d in list)
            {
                Console.WriteLine(d.Method);
                d.DynamicInvoke("Maharashtra");
            }
        }
    }


    //event in delegates
    public delegate void mydel();
    public class student
    {
        public event mydel Fail;
        public event mydel Distinction;

        public void AcceptMarks(int marks)
        {
            if(marks<35)
            {
                Fail(); //Call to the event or raise an event
            }
            else if(marks>=75)
            {
                Distinction();
            }
            Console.WriteLine($"Your Score is {marks}");
        }
    }
    class Stud
    {
        static void failMsg()
        {
            Console.WriteLine("Your are fail..!!");
        }

        static void DistinctionMsg()
        {
            Console.WriteLine("Congratulations! You are pass with Distioction");
        }
        static void Main(string[] args)
        {

            student s1 = new student();
            s1.Fail += new mydel(failMsg);
            s1.Distinction += new mydel(DistinctionMsg);
            s1.AcceptMarks(78);
        }
    }



    /*Assignment: Create a class Bank, assign default account bal using constructor. Add debit method 
    method with parameter debit amt, debit the amount from main bal,
      if bal==0 -> raise an event bal is zero
     if debit amt>bal -> raise an event ->
    credit method with parameter credit amount 
    Add amt to bal->display the updated ac balance.
     */
    public delegate void mydel1();
    public class Bank
    {
        
        public event mydel1 inefficientbal;
        public event mydel1 myamt;
        int balance;

        public Bank()
        {
            balance = 0;
        }
         public void mycredit(int amount )
        {
            balance = balance + amount;
        }

        public void MyDebit(int amt)
        {
            if(balance<amt)
            {
                inefficientbal();
            }
            if(balance>=amt)
            {
                balance = balance - amt;
                if (balance == 0)
                {
                    myamt();
                }
            }

            Console.WriteLine($"Your Balance is {balance}");
        }
    }
    class BankTest
    {
       
            static void Ineffientbal()
            {
                Console.WriteLine("My Balance is ineffient");
            }
            static void MyAmountZero()
            {
                Console.WriteLine("My Balance is Zero");
            }

            static void Main(string[] args)
            {
                Bank b1 = new Bank();
                b1.myamt += new mydel1(MyAmountZero);
                b1.inefficientbal += new mydel1(Ineffientbal);
                b1.mycredit(500);
                b1.MyDebit(400);
            }

        
    }
}
