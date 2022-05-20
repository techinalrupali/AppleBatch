using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.StringDemo
{
    class stringBuilderDemo
    {
        static void Main(string[] args)
        {
            StringBuilder s1 = new StringBuilder("Rupali");
            s1.Append("Rita");
            s1.AppendLine("Piya");
            Console.WriteLine(s1);
            s1.Remove(2, 3);
            Console.WriteLine(s1);
            s1.Insert(7, "Tiya");
            Console.WriteLine(s1);
            string ss=s1.ToString();
            Console.WriteLine(ss);
            s1.Replace('a', '*');
            Console.WriteLine(s1);


        }
    }

    class Demo1
    {
        static void Main(string[] args)
        {
            StringBuilder s1 = new StringBuilder("Rupali");
            for(int i=0;i<s1.Length;i++)
            {
                if (s1[i] == 'i')
                    s1[i] = 'e';
            }

            Console.WriteLine(s1);
            s1.Replace('R', 'S');
            Console.WriteLine(s1);
        }
    }
    class Demo11
    {
        static void Main(string[] args)
        {
            StringBuilder s1 = new StringBuilder("Rupali");
            StringBuilder s2 = new StringBuilder("Dipali");
            Console.WriteLine(s1.ToString()==s2.ToString());
            
            string r1 = new string("Rupali");
            string r2 = new string("Dipali");

            Console.WriteLine(s1==s2);
            Console.WriteLine("***" + Object.ReferenceEquals(s1, s2));
            Console.WriteLine(r1==r2);
        }
    }
    class Demo12
    {
        static void Main(string[] args)
        {
            string m = "Rabbit likes carrot and apple";
            int c = 0;
            string[] arr = m.Split(" ");
            for(int i=0;i<m.Length-1;i++)
            {
                string d = arr[i];
                for(int j=0;j<d.Length-1;j++)
                { 
                    if (d[j]==d[j+1])
                       c++;
                }
            }
            foreach(string d in arr)
                Console.WriteLine(d);
        }
    }
}
