using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Homework.MyExceptionHomeWork
{
    //Foreach 
    class HashDemo
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "Ram");
            ht.Add(2, "Tina");
            ht.Add(3, "Sana");

            foreach(DictionaryEntry d in ht)
                Console.WriteLine(d.Key+" "+d.Value);
           
             
        }
    }
    
    //delete
    class HashDemo1
    {
        static void Main(string[] args)
        {
            Hashtable h1 = new Hashtable();
            h1.Add(1, "Ram");
            h1.Add(2, "Tina");
            h1.Add(3, "Sana");

            h1.Remove(3);
            foreach (DictionaryEntry d in h1)
                Console.WriteLine(d.Key + " " + d.Value);



        }
    }
    
    //Update value
    class HashDemo2
    {
        static void Main(string[] args)
        {
            Hashtable h2 = new Hashtable();
            h2.Add("1", "Ram");
            h2.Add("2", "Tina");
            h2.Add("3", "Sana");

            //update value
            h2["2"] = "Maya";

            foreach (DictionaryEntry d in h2)
                Console.WriteLine(d.Key + " " + d.Value);


        }
    }

    class player1
    {
        int playerid;
        string name;
        string country;
        string team;

        public player1(int playerid, string name, string country, string team)
        {
            this.playerid = playerid;
            this.name = name;
            this.country = country;
            this.team = team;
        }
        public override string ToString()
        {
            return $"playerid={playerid} Name={name} country={country} team={team}";
        }
        public int Playerid { get => playerid; set => playerid = value; }
        public string Name { get => name; set => name = value; }
        public string Country { get => country; set => country = value; }
        public string Team { get => team; set => team = value; }
    }
        class HashDemo3
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(new player1(1, "M.S.Dhoni", "India", "CSK"), 9000);
            ht.Add(new player1(1, "M.S.Dhoni", "India", "CSK"), 9000);

            foreach(DictionaryEntry d in ht)
                Console.WriteLine(d.Key+" "+d.Value);

        }
    }

}
