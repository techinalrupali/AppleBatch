using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.switchcase
{
    class Geometry
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1.Area of Circle 2.Area of Square 3.Area of right angled triangle ");
            Console.WriteLine("4.Area of rectangle 5.Circumference of a circle 6.Perimeter of a square");
            Console.WriteLine("Enter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Console.WriteLine("Enter radius:");
                    float r = Convert.ToSingle(Console.ReadLine());
                    float ac = 3.14f * r * r;
                    Console.WriteLine("Area of Circle:"+ac);
                    break;

                case 2:
                    Console.WriteLine("Enter side:");
                    int x = Convert.ToInt32(Console.ReadLine());
                    int s= x * x;
                    Console.WriteLine("Area of Square:"+s);
                    break;

                case 3:
                    Console.WriteLine("Enter height and base:");
                    float h = Convert.ToSingle(Console.ReadLine());
                    float bs = Convert.ToSingle(Console.ReadLine());
                    float art = 0.5f * h * bs;
                    Console.WriteLine("Area of right angled triangle"+art);
                    break;

                case 4:
                    Console.WriteLine("Enter length and breadth:");
                    int l = Convert.ToInt32(Console.ReadLine());
                    int b = Convert.ToInt32(Console.ReadLine());
                    int ar = l * b;
                    Console.WriteLine("Area of reactangle:"+ar);
                    break;

                case 5:
                    Console.WriteLine("Enter radius:");
                    float R = Convert.ToSingle(Console.ReadLine());
                    float C = 3.14f * 2 * R;
                    Console.WriteLine("Circumference of a circle:"+C);
                    break;

                case 6:
                    Console.WriteLine("Enter side:");
                    int X = Convert.ToInt32(Console.ReadLine());
                    int p = 4 * X;
                    Console.WriteLine("Perimeter of a square:"+p);
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;



            }
        }
    }
}
