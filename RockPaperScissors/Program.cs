using System;
using System.Collections.Generic;

namespace RockPaperScissors.Models
{
    
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Welcome to the Rock Paper Scissors Game");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Here are the rules for the game: ");

            static void GameRules()
            {
                
                Console.WriteLine("Enter 'Rock' to chose Rock");
                Console.WriteLine("Enter 'Scissors' to chose Scissors");
                Console.WriteLine("Enter 'Paper' to chose Paper");

            }


            Console.WriteLine();
            Console.WriteLine("Enter 'Y' to continue or 'N' to end game");
            string userContinue = Console.ReadLine();

            switch (userContinue)
            {
                case "Y":
                    Console.WriteLine("Okay, enter any of the following");
                    break;
                default:
                    break;
            }
            


        }
    }
}