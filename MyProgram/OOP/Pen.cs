using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.OOP
{
    class Pen
    {
        string brand;
        string color;
        int price;

        public void setbrand(string b)
        {
            brand = b;

        }
        public string getbrand()
        {
            return brand;
        }
        public void setcolor(string c)
        {
             color=c;

        }
        public string getcolor()
        {
            return color;
        }
        public void setprice(int rs)
        {
            price=rs;

        }
        public int getprice()
        {
            return price;
        }

    }

    class pentest
    {
        static void Main(string[] args)
        {
            Pen p = new Pen();
            p.setbrand("Cello");
            p.setcolor("Blue");
            p.setprice(10);

            Console.WriteLine("Pen Brand="+p.getbrand());
            Console.WriteLine("Color="+p.getcolor());
            Console.WriteLine("Price="+p.getprice());


            Pen p1 = new Pen();
            Console.WriteLine("Enter Pen Brand:");
            string b = Console.ReadLine();
            p1.setbrand(b);

            Console.WriteLine("Enter Pen Color:");
            string c = Console.ReadLine();
            p1.setcolor(c);

            Console.WriteLine("Enter the pen price:");
            int rs = Convert.ToInt32(Console.ReadLine());
            p1.setprice(rs);

            Console.WriteLine("Pen Brand=" + p1.getbrand());
            Console.WriteLine("Color=" + p1.getcolor());
            Console.WriteLine("Price=" + p1.getprice());





        }
    }
}
