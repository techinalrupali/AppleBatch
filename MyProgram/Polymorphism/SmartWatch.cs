using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.Polymorphism
{
    class SmartWatch
    {
        readonly string brand = "Mi";
        readonly int cost;
        const float gravity = 8.9f;
        public SmartWatch()
        {

        }
        public SmartWatch(string brand, int cost)
        {
            this.brand = brand;
            this.cost = cost;
        }
        public override string ToString()
        {
            return $"Smartwatch Brand={brand}cost={cost} gravity={gravity}";
        }

        public string Brand
        {
            get { return brand; }
        }
        public int Cost
        {
            get { return cost; }
        }
        public float Gravity
        {
            get{ return gravity; }
        }

    }

    class SmartWatchTest
    {
        static void Main(string[] args)
        {
            SmartWatch s1 = new SmartWatch("Noise", 5000);
            Console.WriteLine(s1);
            SmartWatch s2 = new SmartWatch("Apple", 10000);
            Console.WriteLine(s2);
            
        }
    }
}
