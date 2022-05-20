using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.Containment
{
    class Volume
    {
        double v;
        public double volume(double r)
        {
            v =( 4 / 3) *( 22 / 7) *( r*r*r);
            return v;

        }
        public double volume(double h,double r)
        {
            v = (22 / 7) * (r * r) * h;
            return v;
        }
        public double volume(double l,double b,double h)
        {
            v = l * b * h;
            return v;
        }

    }
    class VolumeTest
    {
        static void Main(string[] args)
        {
            Volume v1 = new Volume();
            double a1=v1.volume(2.5);
           double a2= v1.volume(4, 3);
           double a3= v1.volume(3, 4, 5);

            Console.WriteLine("Sphere="+a1);
            Console.WriteLine("Cylinder="+a2);
            Console.WriteLine("Cuboid="+a3);

        }
    }
}
