using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Homework.MyExceptionHomeWork
{
    class DemoLL
    {
        static void Main(string[] args)
        {
            LinkedList<int> l1 = new LinkedList<int>();
            l1.AddLast(85);
            l1.AddLast(92);
            l1.AddLast(83);
            l1.AddLast(63);
            l1.AddFirst(500);

            LinkedListNode<int> nodeafter = l1.Find(83);
            l1.AddAfter(nodeafter, 1000);
            
            foreach(int d in l1)
                Console.WriteLine(d);
        }
    }

    
}
