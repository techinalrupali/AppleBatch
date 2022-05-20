using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Homework.CollectionHomeWork
{
    class Question4
    {
        static void Main(string[] args)
        {
            HashSet<string> hs1 = new HashSet<string>()
            {"A","B","a","V","D","T","M" };

            HashSet<string> hs2 = new HashSet<string>()
            {"a","D","M","A","r"};

            hs1.UnionWith(hs2);
            foreach(string s in hs1) 
               Console.WriteLine(s);
           
        }
    }
}
