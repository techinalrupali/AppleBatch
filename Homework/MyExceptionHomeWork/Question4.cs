using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Homework.MyExceptionHomeWork
{
    class player
    {
        int playerid;
        string name;
        string country;
        string team;

        public player(int playerid, string name, string country, string team)
        {
            this.Playerid = playerid;
            this.Name = name;
            this.Country = country;
            this.Team = team;
        }

        public int Playerid { get => playerid; set => playerid = value; }
        public string Name { get => name; set => name = value; }
        public string Country { get => country; set => country = value; }
        public string Team { get => team; set => team = value; }
    }
    class Question4
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(new player(1, "M.S.Dhoni", "India", "CSK"));
            al.Add(new player(2, "Glenn Maxwell", "Australia", "RCB"));
            al.Add(new player(3, "Tim David", "Australia", "MI"));
            al.Add(new player(4, "Rohit Sharama", "India", "MI"));
            al.Add(new player(5, "Daniel Sams", "Australia", "MI"));
            al.Add(new player(6, "Jason Behrendroff", "Australia", "RCB"));
            al.Add(new player(7, "Mitchell Marsh", "Australia", "DC"));
            al.Add(new player(8, "Virat Kholi", "India", "RCB"));
            al.Add(new player(9, "David Warner", "Australia", "DC"));
            al.Add(new player(10, "Riley Meredith", "Australia", "MI"));

            string max_teamname = "";
            int maxcount = 0;
            foreach(player p1 in al)
            {
                string t = p1.Team;
                int c = 0;
                foreach(player p2 in al)
                {
                    if (p2.Team == t && p2.Country == "Australia")
                        c++;

                }
                if(maxcount<c)
                {
                    max_teamname = p1.Team;
                    maxcount = c;

                }
            }
            Console.WriteLine($"Maximum Austraila players are {max_teamname}={maxcount}");


        }
    }
}
