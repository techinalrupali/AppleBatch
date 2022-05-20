using System;
using System.Collections.Generic;
using System.Text;

namespace Practise
{
    class NumberPresentorNot
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the search number:");
            int search = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<=100;i++)
            {
                if(search>0 && search<=100)
                {
                    Console.WriteLine("Number is present");
                }
                else
                {
                    Console.WriteLine("number is not present");
                }
            }
        }
    }
}
