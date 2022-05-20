using System;

namespace MyProgram.OOP
{
    class Car
    {

        int num;
        string brand;
        string color;
        int price;

        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.num = 101;
            c1.brand = "Honda";
            c1.color = "Black";
            c1.price = 100000;

            Car c2 = new Car();
            c2.num = 102;
            c2.brand = "Tata";
            c2.color = "Blue";
            c2.price = 150000;

            Console.WriteLine("Num="+c1.num);
            Console.WriteLine("Brand="+c1.brand);
            Console.WriteLine("Color="+c1.color);
            Console.WriteLine("Price="+c1.price);

            Console.WriteLine("Num="+c2.num);
            Console.WriteLine("Brand="+c2.brand);
            Console.WriteLine("Color="+c2.color);
            Console.WriteLine("Price="+c2.price);


        }

    }
}
