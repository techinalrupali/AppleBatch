using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.PractiseDemo
{
    class employee
    {
        int id;
        string name;

        public employee(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public override string ToString()
        {
            return $"ID={id} Name={name}";
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
    class Class1
    {

        static void Main(string[] args)
        {

            employee e1 = new employee(1, "ABC");
            employee e2 = new employee(2, "BAC");
            employee e3 = new employee(3, "CDA");
            employee e4 = new employee(4, "MNA");
            employee e5 = new employee(5, "BBB");
            employee[] emp = new employee[5];

            emp[0] = e1;
            emp[1] = e2;
            emp[2] = e3;
            emp[3] = e4;
            emp[4] = e5;

            foreach (employee e in emp)
            {
                Console.WriteLine(e);
            }
        }
    }

    //does not declare data type directly using properties.
    public class emp11
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
    }

    class emp11Test
    {
        static void Main(string[] args)
        {
            emp11[] e = new emp11[]
            {
                    new emp11{Id=1,Name="ABC",Salary=20000},
                    new emp11{Id=2,Name="CID",Salary=25000},
                    new emp11{Id=3,Name="PQR",Salary=30000},
                    new emp11{Id=4,Name="MNO",Salary=35000},
                  


            };
            foreach(emp11 e1 in e)
            {
                Console.WriteLine($"ID={e1.Id} Name={e1.Name} Salary={e1.Salary}");
            }
        }
    }

    //same(emp) example of product 

    public class product
    {
        public int id { get; set; }
        public string pname { get; set; }
        public double pprice { get; set; }
    }

    class productTest
    {
        static void Main(string[] args)
        {
            product[] p = new product[]
            {
                new product{id=1,pname="Pen",pprice=10},
                new product{id=2,pname="Pencil",pprice=5},
                new product{id=3,pname="Book",pprice=50},
                new product{id=4,pname="NoteBook",pprice=100},
                new product{id=5,pname="Eraser",pprice=5},

            };

            foreach (product p1 in p)
            {
                Console.WriteLine($"ID={p1.id} Name={p1.pname} Price={p1.pprice}");
            }
        }

    }

    //user defined 2D array
    class ArrayDemo1
    {
        static void Main(string[] args)
        {
            int[,] a = new int[4, 3];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(i + "" + j + "");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(a[i, j]);
                }
            }
            Console.WriteLine();

        }
    }

    // 2D array print( 4 rows and 3 columns using for display)
    class ArrayDemo2
    {
        static void Main(string[] args)
        {
            int[,] a1 = new int[,]
            {
               { 4,3,2}, {5,6,8 },{8,9,7 },{4,6,8 }

            };

            for(int i=0;i<a1.GetLength(0);i++)
            {
                for(int j=0;j<a1.GetLength(1);j++)
                {
                    Console.Write(a1[i,j]+"");
                    Console.WriteLine();
                }
            }
        }
    }
    //jagged array
    class ArrayDemo3
    {
        static void Main(string[] args)
        {
            int[][] a1 = new int[4][];

            a1[0] = new int[2];
            a1[1] = new int[3];
            a1[2] = new int[4];
            a1[3] = new int[5];

            for (int i = 0; i < a1.GetLength(0); i++)
            {
                Console.WriteLine("Enter elements in row:");
                for (int j = 0; j < a1[i].Length; j++)
                {
                    a1[i][j] = int.Parse(Console.ReadLine());
                }

            }
            for (int i = 0; i < a1.GetLength(0); i++)
            {
                Console.WriteLine("Enter elements in row:");
                for (int j = 0; j < a1[i].Length; j++)
                {
                    Console.Write(a1[i][j] + " ");
                }
                Console.WriteLine();
            }

        }

    }

    //dictionary collection using country code and country name example
    class DictionaryDemo
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d1 = new Dictionary<int, string>();
            d1.Add(91, "India");
            d1.Add(93, "USA");
            d1.Add(95, "England");

            foreach(KeyValuePair<int,string> k in d1)
            {
                Console.WriteLine(k.Key+" "+k.Value);
            }
        }
    }

    //generic method constant data types
    public class Test<T>    //placeholder for type(data type)
        {
            T element;
            public void Add(T element)
            {
                this.element = element;
            }
            public T Display()
            {
                return element;
            }
        }

  
    class GenericDemo
    { 
        static void Main(string[] args)
        {
            Test<int> t1 = new Test<int>();
            t1.Add(1);
            Console.WriteLine(t1.Display());

            Test<string> t2 = new Test<string>();
            t2.Add("ABC");
            Console.WriteLine(t2.Display());
        }
    }

    //swap any two data types using generic method
    class GenericDemo1
    {
        static void Swap<T>(T a, T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"a={a} b={b}");

        }
        static void Main(string[] args)
        {
            Swap<int>(50, 100);
            Swap<string>("Hello", "Hii");
            Swap<Double>(50.50, 25.25);
        }
    }
    

    // ref keywords
    class program
    {
        static void swap<T>(ref T a,ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;


        }
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            swap<int>(ref a, ref b);
            Console.WriteLine($"a={a} b={b}");
        }
    }
   
    //out keywords
    class outDemo
    {
        static void calculation(int a, int b, out int sum, out int multiply)
        {
            sum = a + b;
            multiply = a * b;
        }



    static void Main(string[] args)
        {
            int a = 20, b = 30, sum, multiply;
            calculation(a, b, out sum, out multiply);
            Console.WriteLine($"add={sum} Multiply={multiply}");

        }
    }
}
