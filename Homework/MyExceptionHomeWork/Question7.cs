using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Homework.MyExceptionHomeWork
{
    class Question7
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1,"Ram");
            ht.Add (2,"Siya");
            ht.Add(3,"Priya");
            ht.Add(4,"Sagar");
            ht.Add(5,"Maya");
            ht.Add(6, "Abhi");
            ht.Add(7,"Veeru");
            ht.Add(8,"Neeta");
            ht.Add(9,"Ankita");
            ht.Add(10,"Radhika");

            DictionaryEntry[] a1 = new DictionaryEntry[ht.Count];
            ht.CopyTo(a1, 0);
            for(int i=0;i<a1.Length;i++)
            {
                int c = 0;
                dynamic k = a1[i].Key;
                if(k%3==0)
                {
                    ht.Remove(k);
                    c++;

                }
            }
            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key + "=" + d.Value);
            }
        }
    }
}
