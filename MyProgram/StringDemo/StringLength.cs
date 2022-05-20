using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.StringDemo 
{
    class StringLength
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            string s2 = Console.ReadLine();
            Console.WriteLine("Length="+s2.Length);
        }
    }

    class TrimDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            string s2 = Console.ReadLine();
            Console.WriteLine("Length=" + s2.Length);
            string ss = s2.Trim();
            Console.WriteLine("Length="+s2.Length);
        }
    }

    class IndexDemo
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter name");
            string s2 = Console.ReadLine();
            int idx = s2.IndexOf('p');
            int lastidx = s2.LastIndexOf('a');
            Console.WriteLine(idx);
            Console.WriteLine(lastidx);

        }
    }

    class SubstringDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name:");
            string s2 = Console.ReadLine();
            Console.WriteLine(s2.Substring(2));
            Console.WriteLine(s2.Substring(2,3));
        }
    }

    class StringTocharDemo
    { 
        static void Main(string[] args)
        {
            string ss = "Rupali";
            Console.WriteLine(ss[0]);
            char[] s = ss.ToCharArray();
            // s[2] = 'T';
            // string snew = new string(s);


            string s2 = "Rita";
            string dd = s2.Replace('R', 'N');
            Console.WriteLine(s2);
            Console.WriteLine(dd);
        }
    }

    class StringDemo1
    {
        static void Main(string[] args)
        {
            String ss = "Rupali Birajdar";
            string dd = "";
            for(int i=0;i<ss.Length;i++)
            {
                if (ss[i] != 'a')
                    dd = dd + ss[i];
            }
            Console.WriteLine(dd);
        }
    }

    

}
