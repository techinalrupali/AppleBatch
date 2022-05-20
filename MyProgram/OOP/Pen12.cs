using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.OOP
{
    class Pen12
    {
        string brand;
        string color;
        int price;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }

        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
    }
    class pentest12
    {
        static void Main(string[] args)
        {
            Pen12 p12 = new Pen12();
            p12.Brand="Cello";
            p12.Color="Blue";
            p12.Price=10;

            Console.WriteLine("Pen Brand=" + p12.Brand);
            Console.WriteLine("Color=" + p12.Color);
            Console.WriteLine("Price=" + p12.Price);

        }
    }
}
