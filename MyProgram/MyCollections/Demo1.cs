﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace MyProgram.MyCollections
{
    class Demo1
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();
            a1.Add("ABC");
            Console.WriteLine(a1.Count);
            Console.WriteLine(a1.Capacity);
            a1.Add(80);
            a1.Add("ABC@gmail.com");
            a1.Add(true);
            a1.Add("Pune");
            a1.Insert(2, "EBC");
           // a1.Reverse();
            a1.Remove(3);
            
            for(int i=0;i<a1.Count;i++)
            {
                Console.WriteLine(a1[i]);
            }
            
        }
    }
}
