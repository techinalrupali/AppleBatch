using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Homework.MyExceptionHomeWork
{
    /*
     8.	ArrayList Contains 
      al.Add("pune");
      al.Add("Mumbai");
      al.Add("pune");
      al.Add("Mumbai");
      al.Add("Nasik");
      al.Add("pune");
     Create a HashTable which contain String as key and Integer as value key is name of city and value is frequency of that city.
     ("pune",3);
     ("Mumbai",2);
     Print hashtableusing Foreach loop.
    
     */
    class Question8
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Pune");
            al.Add("Mumbai");
            al.Add("Pune");
            al.Add("Mumbai");
            al.Add("Nasik");
            al.Add("Pune");

            int c = 0;
            for (int i = 0; i < al.Count; i++)
            {
                for (int j = 0; j < al.Count; j++)
                {
                    if (al[i] == al[j] && i > j)
                        break;
                    if (al[i] == al[j])
                        c++;
                }
                if (c != 0)
                    Console.WriteLine($"Frenquency of {al[i]} is= " + c);
                c = 0;


            }
        }
    }
}
