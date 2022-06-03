using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Quizs
    {
        string question;
        string option_A;
        string option_B;
        string option_C;
        string option_D;
        string correct_option;

       public Quizs()
        {

        }

        public Quizs(string question, string option_A, string option_B, string option_C, string option_D, string correct_option)
        {
            this.Question = question;
            this.Option_A = option_A;
            this.Option_B = option_B;
            this.Option_C = option_C;
            this.Option_D = option_D;
            this.Correct_option = correct_option;

        }

        public override string ToString()
        {
            return $"{Question}\n {option_A}\n {option_B}\n{option_C}\n {option_D}";
        }

        public string Question { get => question; set => question = value; }
        public string Option_A { get => option_A; set => option_A = value; }
        public string Option_B { get => option_B; set => option_B = value; }
        public string Option_C { get => option_C; set => option_C = value; }
        public string Option_D { get => option_D; set => option_D = value; }
        public string Correct_option { get => correct_option; set => correct_option = value; }
    }

    class Quiz1
    {
        static List<Quizs> java = new List<Quizs>();
        static List<Quizs> csharp = new List<Quizs>();
        static List<Quizs> html = new List<Quizs>();
        Dictionary<string, List<Quizs>> dt = new Dictionary<string, List<Quizs>>();
        static int score = 0;
       public static void JavaQuiz()
        {
            java.Add(new Quizs("Q1)-Who invented java programming?", "A-Guido van Rossum", "B-James Gosling", "C-Dennis Ritchie", "D-Bjarne Stroustrup", "B"));
            java.Add(new Quizs("Q2)-What is the extension of java code files?","A-.js","B-.txt","C-.class","D-.java","D"));
            java.Add(new Quizs("Q3)-Which of the following is not an OOPs concept in java?", "A-Polymorphism", "B-Inheritance", "C-Compilation", "D-Encapsulation", "C"));
            java.Add(new Quizs("Q4)-Arrays in java are","A-Object References","B-Objects","C-Primitive data type","D-None","B"));
            java.Add(new Quizs("Q5)-compareTo() returns","A-True","B-False","C-An int value","D-None","C"));
            java.Add(new Quizs("Q6)-Where is System class defined?","A.java.lang.package","B-java.util.package","C-java.io.package","D-None","A"));
            java.Add(new Quizs("Q7)-Which of the following is not a primitive data type?","A-Boolean","B-Byte","C-String","D-Double","C"));
            java.Add(new Quizs("Q8)-In java, jar stands for","A-Java Archive Runner","B-Java Application Resource","C-Java Application Runner","D-None","D"));
            java.Add(new Quizs("Q9)-On which Platforms java runs?", "A-Windows","B-Mac OS","C-UNIX","D-All of these","D"));
            java.Add(new Quizs("Q10)-Which one of the following is not a java feature?","A-Object-oriented","B-Use of pointers","C-Portable","D-Dynamic and Extensible","B"));

           for (int i = 0; i < java.Count; i++)
            {
                Console.WriteLine(java[i]);
                Console.Write("Enter your choice=");
                string choice = Console.ReadLine();
                if (java[i].Correct_option == choice.ToUpper())
                    score++;

            }
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("\n Your Score is "+score);
            Console.WriteLine("***********************************************************************");


        }
       public static void CSharpQuiz()
        {
            csharp.Add(new Quizs("1-CLR means-", "A-Common Local Runtime", "B-Common Language Runtime", "C-Common Laguage Realtime", "D-Common Local Realtime", "B"));
            csharp.Add(new Quizs("2-Arrays in C# are ____ objects", "A-Reference", "B-Lgical", "C-value", "D-Arithmetic", "A"));
            csharp.Add(new Quizs("3-C# does not support_____constructors", "A-Parameterized", "B-Parameter-Less", "C-Class", "D-Method", "B"));
            csharp.Add(new Quizs("4-IL in .Net means ________?", "A-Intermediate Language", "B-International Language", "C-Interoperate Language", "D-Intermediate Local", "A"));
            csharp.Add(new Quizs("5-C# was developed by", "A-Bjarne Stroustrup", "B-Anders Hejlsberg", "C-Dennis M.Ritchie", "D-Rasmus Lerdorf", "B"));
            csharp.Add(new Quizs("6-Struct’s data members are _____ by default.", "A-Protected", "B-Public", "C-Private", "D-Default", "C"));
            csharp.Add(new Quizs("7- C# doesnot support:", "A-Abstraction", "B-Polymorphism", "C-Multiple inheritance", "D-Inheritance", "C"));
            csharp.Add(new Quizs("8-C# runs on the_____.", "A- .NET Framework", "B-Java Virtual Machine", "C-Both A and B", "D-None", "A"));
            csharp.Add(new Quizs("9-C# is programming language, developed by__", "A-Oracle", "B-Microsoft", "C-GNU Project", "D-Google", "B"));
            csharp.Add(new Quizs("10-C# programming language is used to develop.", "A-Web Apps", "B-Desktop Apps", "C-Mobiles Apps", "D-All of above", "D"));

            for (int i = 0; i <csharp.Count; i++)
            {
                Console.WriteLine(csharp[i]);
                Console.Write("Enter your choice=");
                string choice = Console.ReadLine();
                if (csharp[i].Correct_option == choice.ToUpper())
                    score++;

            }
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("\n Your Score is " + score);
            Console.WriteLine("***********************************************************************");
        }
        public static void HtmlQuiz()
        { 
            html.Add(new Quizs("1-HTML stand for?", "A-HighText Machine Language","B-HyperText and links Markup Language","C-HyperText Markup Language","D-None of these","C"));
            html.Add(new Quizs("2- Which of the following tag is used to add rows in the table?", "A-<td> and </td>", "B-<th> and </th>", "C-<tr> and </tr>", "D-None of the above","C"));
            html.Add(new Quizs("3-The <hr> tag in HTML is used for -", "A-new line", "B-vertical ruler", "C-new paragraph", "D-horizontal ruler","D"));
            html.Add(new Quizs("4- Which of the following is the paragraph tag in HTML?", "A-<p>", "B-<b>", "C-<pre>", "D-None of the above","A"));
            html.Add(new Quizs("5-An HTML program is saved by using the ____ extension.", "A-.ht", "B-.html", "C-.hml", "D-None of the above","B"));
            html.Add(new Quizs("6-The tags in HTML are -", "A-case-sensitive","B-in upper case","C-not case sensitive","D-in lowercase","C"));
            html.Add(new Quizs("7-Who is the father of HTML?", "A-Rasmus Lerdorf","B-Tim Berners -Lee","C-Brendan Eich","D Sergey Brin","B"));
            html.Add(new Quizs("8- HTML is a subset of _____", "A-SGMT", "B- SGML","C-SGME", "D-XHTML","B"));
            html.Add(new Quizs("9- Which tag is used to create a blank line in HTML?", "A-<b>", "B-<br>", "C-<em>", "D-<a>","B"));
            html.Add(new Quizs("10-Which tag is used to underline the text in HTML?", "A-<p>", "B-<u>", "C-<i>", "D-<ul>","B"));

            for (int i = 0; i < html.Count; i++)
            {
                Console.WriteLine(html[i]);
                Console.Write("Enter your choice=");
                string choice = Console.ReadLine();
                if (html[i].Correct_option == choice.ToUpper())
                    score++;

            }
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("\n Your Score is " + score);
            Console.WriteLine("***********************************************************************");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Login User\n Enter your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("*****************************************************************");
            string choice;
         
                Console.WriteLine($"Welcome {name}....!!!!!!\nfor playing Quiz:\n ");
                Console.WriteLine(" 1:-Java \n 2:-Csharp \n 3:-HTML\n ");
                Console.WriteLine("*****************************************************************");
                Console.WriteLine("Enter Your Choice:");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        JavaQuiz();
                        Console.WriteLine("");
                        break;

                    case "2":
                        CSharpQuiz();
                        Console.WriteLine("");
                        break;

                    case "3":
                        HtmlQuiz();
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Invalid entry!");
                        break;


                }
            Console.WriteLine("Do you Play Again(y/n):");
            string enter = Console.ReadLine();
   
            
       

          
        }

    }

}
