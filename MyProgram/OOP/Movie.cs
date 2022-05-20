using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram.OOP
{
    class Movie
    {
        String moviename;
        String directorName;
        String producer;
        String actorname;
        int rate;
        int mRating;



        public void setMovieName(String mn)
        {
            moviename = mn;

        }
        public string getMovieName()
        {
            return moviename;
        }

        public void setDirectorName(String dn )
        {
            directorName = dn;
        }
        public string getDirectorName()
        {
            return directorName;
        }
         public void setproducer(string p)
        {
            producer = p;

        }
        public string getproducer()
        {
            return producer;

        }
        public void setactorname(string an)
        {
            actorname = an;
        }
        public string getactorname()
        {
            return actorname;
        }
        public void setrating(int r)
        {
            rate = r;
        }
        public int getrating()
        {
            return rate;
        }
     
        static void Main(string[] args)
        {
            Movie m = new Movie();
            Console.WriteLine("Enter the MoiveName:");
            string mn = Console.ReadLine();
            m.setMovieName(mn);

            Console.WriteLine("Enter the DirectorName:");
            string dn = Console.ReadLine();
            m.setDirectorName(dn);

            Console.WriteLine("Enter the Producer:");
            string p = Console.ReadLine();
            m.setproducer(p);

            Console.WriteLine("Enter the ActorName:");
            string an = Console.ReadLine();
            m.setactorname(an);

            Console.WriteLine("Enter Rating:");
            int r = Convert.ToInt32(Console.ReadLine());
            m.setrating(r);

            Console.WriteLine(m.getMovieName());
            Console.WriteLine(m.getDirectorName());
            Console.WriteLine(m.getproducer());
            Console.WriteLine(m.getactorname());
            Console.WriteLine(m.getrating());




        }

    }
}
