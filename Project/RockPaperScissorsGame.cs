using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class RockPaperScissorsGame
    {
        static void Main(string[] args)
        {
            string inputPlayer,inputCPU;
            int randomInt;

            bool playAgain = true;

            while (playAgain)
            {

                int scorePlayer = 0;
                int scoreCPU = 0;

                Console.WriteLine("Login User\nEnter your Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("*****************************************************************");
                Console.WriteLine($"Welcome {name}....!!!!!!\nfor playing Game:\n ");
                Console.WriteLine("*****************************************************************");

                while (scorePlayer < 3 && scoreCPU < 3)
                {
                    Console.Write("Choose between ROCK, PAPER and SCISSORS:\n");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("Computer choose ROCK");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("DRAW...!!\n\n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("PLAYER WINS...!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("CPU WINS...!!\n\n");
                                scoreCPU++;
                            }
                            break;
                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("Computer choose PAPER");
                            if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("DRAW...!!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("CPU WINS...!!\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("PLAYER WINS...!!\n\n");
                                scorePlayer++;
                            }
                            break;
                        case 3:
                            inputCPU = "SCISSORS";
                            Console.WriteLine("Computer choose SCISSORS");
                            if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("DRAW...!!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("PLAYER WINS...!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("CPU WINS...!!\n\n");
                                scoreCPU++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid entry!");
                            break;
                    }
            
                    Console.WriteLine("\nSCORES:\nPLAYER:\t{0}\tCPU:\t{1}", scorePlayer, scoreCPU);
                    Console.WriteLine("*****************************************************************************");

                }

                if (scorePlayer == 3)
                {
                    Console.WriteLine("Player WON...!!");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("CPU WON...!!");
                }
                else
                {

                }

                Console.WriteLine("Do you want to play again?(y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
                else
                {

                }

            }
        }
    }
}
