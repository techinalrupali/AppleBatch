using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Collections;



namespace MyProgram
{
    enum Role
    {
       Admin,Developer,Tester
    }
    class Enumclass
    {
        string name;
        Role role;

        public string Name { get => name; set => name = value; }
        public Role Role { get => role; set => role = value; }

        public override string ToString()
        {
            return $"Name:{name} Role:{role}";
        }

        static void Main(string[] args)
        {
            Enumclass e = new Enumclass();
            Console.WriteLine("Enter Name:");
            string nm = Console.ReadLine();
            Console.WriteLine("Select Role form following list");
            
            foreach(var d in Enum.GetNames(typeof(Role)))
                Console.WriteLine(d);
            
            Console.WriteLine("Enter your choice:");
            string choice = Console.ReadLine();
           
            e.Name= nm;
            e.Role = Enum.Parse<Role>(choice);
            Console.WriteLine(e);


        }
    }
}
