﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Loops
{
    class Break
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=10;i++)
            {
                if(i==7)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}
