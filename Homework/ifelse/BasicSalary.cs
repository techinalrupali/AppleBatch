﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.ifelse
{
    class BasicSalary
    {
        static void Main(string[] args)
        {
            int salary, gross, hra, da;
            Console.WriteLine("Enter the Basic salary of the employee");
            salary = Convert.ToInt32(Console.ReadLine());

            if(salary<=10000)
            {
                da = salary * 80 / 100;
                hra = salary * 20 / 100;
                gross = salary + da + hra;
                Console.WriteLine("The gross salary of the employee is"+gross);
            }
            else if(salary<=20000)
            {
                da = salary * 90 / 100;
                hra = salary * 25 / 100;
                gross = salary + da + hra;
                Console.WriteLine("The gross salary of the employee is" + gross);
            }
            else if(salary>20000)
            {
                da = salary * 95 / 100;
                hra = salary * 30 / 100;
                gross = salary + da + hra;
                Console.WriteLine("The gross salary of the employee is" + gross);
            }
            else
            {
                Console.WriteLine("You have no salary");
            }

        }
    }
}
