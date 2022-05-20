using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Homework.MyExceptionHomeWork
{
    /*
    	Assume you have Arraylist al = new ArrayList();
       al.Add("Sun");
         al.Add("Mon");
         al.Add("Sat");
         al.Add("Sun ");
         al.Add("Mon ");
         al.Add("Sat ");
         al.Add("Sun ");
         al.Add("Sat ");
         al.Add("Sun ");
         al.Add("Mon ");
      Write a code to remove duplicate elements from above list.
     Final Arraylist should contain (Sun, Mon, Sat);
    */


    class Question1
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Mon");
            Console.WriteLine("Before Element=");
            foreach (var d in al)
            {
                Console.WriteLine(d);

            }
            for (int i = 0; i < al.Count; i++)
            {
                int c = 0;
                for (int j = 0; j < al.Count; j++)
                {

                    if (al[i] == al[j] && c == 1)
                    {
                        al.RemoveAt(j);
                    }
                    else if (al[i] == al[j])
                        c++;
                }
            }
            Console.WriteLine("After Element=");
            foreach (var d in al)
            {
                Console.WriteLine(d);
            }


        }
    }
}
