using System;
using System.Collections.Generic;
using System.Text;

namespace Practise
{
    class SymmetricorNot  
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[10,10];
            int m, n, x = 0, y = 0;
            Console.WriteLine("Enter the number of row and column :");
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the martix elements:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i,j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[i,j] != arr[i,j])
                        x = 1;
                    else if (arr[i,j] == -arr[j,i])
                        y = 1;
                }
            }

            if (x == 0)
                Console.WriteLine("Symmeteric martix");
            else
                Console.WriteLine("not Symmeteric martix");



        }
    }
}
