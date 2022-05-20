using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.Polymorphism
{
    class AA
    {
        public virtual void play()
        {
            Console.WriteLine("Play on ground");
        }
        public virtual void study()
        {
            Console.WriteLine("study by reading books ");
        }
    }
    class BB:AA
    {
        public override void study()
        {
            Console.WriteLine("learning from online video");
        }
    }

    class CC : BB 
    {
        public sealed override void study()
        {
            Console.WriteLine("I am Study in online");
        }
    }

    class AATest
    {
        static void Main(string[] args)
        {
            AA a12 = new AA();
            a12.play();
            a12.study();
            Console.WriteLine("************************************");
            BB b1 = new BB();
            b1.study();
            Console.WriteLine("************************************");
            AA a13 = new BB();
            a13.study();
            Console.WriteLine("*************************************");
            CC c1 = new CC();
            c1.study();
            Console.WriteLine("*************************************");
            b1 = new CC();
            b1.study();



        }
    }
}

