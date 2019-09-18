using System;

namespace Cafe
{
    class Program
    {
        static void Main(string[] args)
        {

            char userChoice = ' ';

            Console.WriteLine("Please choose one of the following options");
            Console.WriteLine("1 - Cappucino");
            Console.WriteLine("2 - Latte");
            Console.WriteLine("3 - Americano");
            Console.WriteLine("Q - Quit");

            while (!userChoice.Equals('q'))
            {
                userChoice = char.ToLower(Console.ReadKey(true).KeyChar);
                Console.WriteLine("You chose " + userChoice);
            }

        }
    }
}
