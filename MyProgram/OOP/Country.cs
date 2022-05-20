using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.OOP
{
    class Country
    {
        string countryname;
        int no_of_states;
        int no_of_language;
        string capital;

      public string Countryname
        {
            get { return countryname; }
            set { countryname = value; }
        }
        public int No_of_states
        {
            get { return no_of_states; } 
            set { no_of_states = value; }
        }
        public int No_of_language
        {
            get { return no_of_language; }
            set { no_of_language = value; }
        }
        public string Capital
        {
            get { return capital; }
            set { capital = value; }
        }
    }
    
    class Countrytest
    {
        static void Main(string[] args)
        {
            Country c1 = new Country();
            c1.Countryname = "India";
            c1.No_of_states = 29;
            c1.No_of_language = 10;
            c1.Capital = "Delhi";
            Console.WriteLine("Country Name="+c1.Countryname);
            Console.WriteLine("No of States="+c1.No_of_states);
            Console.WriteLine("No of Language="+c1.No_of_language);
            Console.WriteLine("Capital="+c1.Capital);


        }
    }

}
