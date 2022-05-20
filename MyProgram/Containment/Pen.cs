using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.Containment
{
    class Pen
    {
        int capLength;
        string brand;
        Refill r=new Refill();

        public int CapLength
        {
            get { return capLength; }
            set { capLength = value; }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public Refill R
        {
             get {return r; }
             set { r = value; }
        }
    }
    class Refill
    {
        string inkColor;
        float length;
        Nib n= new Nib();

        public string Inkcolor
        {
            get { return inkColor; }
            set { inkColor = value; }
        }
        public float Length
        {
            get { return length; }
            set { length = value; }
        }
        public Nib N
        {
            get { return n; }
            set { n = value; }
        }

    }
    class Nib
    {
        string materialType;
        float width;

        public string MaterialType
        {
            get { return materialType; }
            set { materialType = value; }
        }
        public float Width
        {
            get { return width; }
            set { width = value; }
        }
    }

    class PenTest1
    {
        static void Main(string[] args)
        {
            Pen p1 = new Pen();
            Console.WriteLine("Enter the Cap Length:");
            p1.CapLength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Brand:");
            p1.Brand = Console.ReadLine();
            Console.WriteLine("Enter the InkColor:");
            p1.R.Inkcolor = Console.ReadLine();
            Console.WriteLine("Enter the Length:");
            p1.R.Length = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the Material Type:");
            p1.R.N.MaterialType = Console.ReadLine();
            Console.WriteLine("Enter the width");
            p1.R.N.Width = Convert.ToSingle(Console.ReadLine());


            Console.WriteLine("Cap Length="+p1.CapLength);
            Console.WriteLine("Brand="+p1.Brand);
            Console.WriteLine("Ink Color="+p1.R.Inkcolor);
            Console.WriteLine("Length="+p1.R.Length);
            Console.WriteLine("Material Type="+p1.R.N.MaterialType);
            Console.WriteLine("Width="+p1.R.N.Width);

        }
    }
}
