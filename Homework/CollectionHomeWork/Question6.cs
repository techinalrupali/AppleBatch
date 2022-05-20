using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Homework.CollectionHomeWork
{
    class Question6
    {
        static void Main(string[] args)
        {
            Dictionary<string,float> d= new Dictionary<string, float>();
            d.Add("One", 1.5f);
            d.Add("Three", 2.5f);
            d.Add("four", 5.5f);
            d.Add("six", 6.5f);
            d.Add("Two", 0.5f);

            foreach(KeyValuePair<string,float> dd in d)
                Console.WriteLine(dd.Key+" "+dd.Value);



        }
    }
}
