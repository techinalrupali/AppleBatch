using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.Polymorphism
{
    class Parent
    {
        public void play()
        {
            Console.WriteLine("Play on ground");
        }
        public virtual void study()
        {
            Console.WriteLine("study by reading books ");
        }
    }
    class Child:Parent
    {
        public override void study()
        {
            Console.WriteLine("learning from online video");
        }
    }

    class childTest
    {
        static void Main(string[] args)
        {
            Parent p1 = new Parent();
            p1.play();
            p1.study();
            Console.WriteLine("******************************************");
            Child c1 = new Child();
            c1.study();
            Console.WriteLine("******************************************");
            Parent p2 = new Child();
            p2.study();

        }
    }

}
