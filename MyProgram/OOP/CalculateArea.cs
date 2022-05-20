using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.OOP
{
    class CalculateArea
    {
        public void Area(int side)
        {
            Console.WriteLine("Area of Square:"+(side*side));
        }
        public void Area(int l, int b)
        {
            Console.WriteLine("Area of Rectangle:"+(l*b));

        }
        public void Area(float pi,int r)
        {
           Console.WriteLine("Area of Circle:"+(3.14*r*r));
        }
    }

    class Geometry
    {
        static void Main(string[] args)
        {
            CalculateArea ca = new CalculateArea();
            ca.Area(5);
            ca.Area(4, 3);
            ca.Area(3.14f, 4);
        }
    }
}
