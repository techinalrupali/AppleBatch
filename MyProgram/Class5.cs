using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram
{
    class Class5
    {//o/p= 30,70,110,150
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40 ,50,60,70,80};
            int sum = 0;
            for(int i=0; i<arr.Length-1;i=i+2)
            {
                
                sum = arr[i] + arr[i+1];
                Console.WriteLine(sum);


            }
            

        }
    }
}
