using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MyProgram.PractiseDemo
{
    //thread and multithreading
    class MultithreadingDemo
    {
       
        
        public void Run()
        {
            Thread t = Thread.CurrentThread;//returns the name currently executing thread
           
            for (int i=1;i<10;i++)
            {
                Console.WriteLine(t.Name);
                Console.WriteLine(i);
                Thread.Sleep(2000);//it's stops 2sec
            }
        }
    }

    class Class3
    {
        static void Main(string[] args)
        {
            MultithreadingDemo md = new MultithreadingDemo();
            Thread t1 = new Thread(new ThreadStart( md.Run));
            Thread t2 = new Thread(new ThreadStart(md.Run));
            Thread t3 = new Thread(new ThreadStart(md.Run));
            t1.Name = "t1 Thread";
            t2.Name = "t2.Thread";
            t3.Name = "t3.Thread";
            t1.Priority = ThreadPriority.Lowest;
            t2.Priority = ThreadPriority.AboveNormal;
            t3.Priority = ThreadPriority.Highest;

            t1.Start();
            t1.Join();//block the other thread's execution, t1 will completed its task.
            t2.Start();
            t3.Start();
        }
    }

    //Thread Synchronization
    class Demo
    {
        public void Run()
        {
            Thread t = Thread.CurrentThread;
            lock(this)//this ref to current thread
            {
                for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine(t.Name);
                    Console.WriteLine(i);
                    Thread.Sleep(2000);//it's stops 2sec
                }
            }

        }
    }
    class Demotest
    {
        static void Main(string[] args)
        {
            Demo d1 = new Demo();
            Thread t1 = new Thread(new ThreadStart(d1.Run));
            Thread t2 = new Thread(new ThreadStart(d1.Run));
            Thread t3 = new Thread(new ThreadStart(d1.Run));
            t1.Name = "t1 Thread";
            t2.Name = "t2.Thread";
            t3.Name = "t3.Thread";
            
            t1.Start();
            t2.Start();
            t3.Start();

        }
    }
}
