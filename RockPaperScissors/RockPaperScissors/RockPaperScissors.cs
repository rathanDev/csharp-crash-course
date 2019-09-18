using System;

namespace RockPaperScissors
{
    class Program
    {
        private const int Rock = 0;
        private const int Paper = 1;
        private const int Scissors = 2;
        private const int Invalid = -1;

        static void Main(string[] args)
        {

            Random randomNumbers = new Random();

            string playerChoice = "";
            int playerValue = Invalid;

          
            Console.Clear();     
       
            while(!playerChoice.Equals("q"))
            {
                Console.WriteLine("Please enter rock, paper or scissors ---> ");
                playerChoice = Console.ReadLine().ToLower();

                if (playerChoice.Equals("rock"))
                {
                    playerValue = Rock;
                }
                else if (playerChoice.Equals("paper"))
                {
                    playerValue = Paper;
                }
                else if (playerChoice.Equals("scissors"))
                {
                    playerValue = Scissors;
                } else if (playerChoice.Equals("q"))
                {
                    Console.WriteLine($"Player wants to quit...");
                    return;
                }
                else 
                {
                    Console.WriteLine("Invalid input");
                    playerValue = Invalid;
                }

                Console.WriteLine($"Player chose {playerChoice}, player value {playerValue}");

                int computerValue = randomNumbers.Next(3);
                string computerChoice;
                if(computerValue == Rock)
                {
                    computerChoice = "rock";
                } else if (computerValue == Paper)
                {
                    computerChoice = "paper";
                }
                else if (computerValue == Scissors)
                {
                    computerChoice = "scissors";
                } else
                {
                    computerChoice = "invalid";
                }
                Console.WriteLine($"Computer chose {computerChoice}, computer value {computerValue}");
                
                if (playerValue == computerValue)
                {
                    Console.WriteLine("It's a draw");
                }
                else if ((playerValue==Scissors && computerValue==Paper) || (playerValue==Paper && computerValue==Rock) || (playerValue==Rock && computerValue==Scissors))
                {
                    Console.WriteLine("Player wins");
                }
                else
                {
                    Console.WriteLine("Computer wins");
                }
            }

        }
    }
}
