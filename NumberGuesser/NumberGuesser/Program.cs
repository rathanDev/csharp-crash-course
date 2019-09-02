using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int fn = random.Next(2, 10);
            int sn = random.Next(2, 10);
            int subtraction = random.Next(2, 10);
            int answer = fn * sn - subtraction;

            String prompt = "... Press enter when ready";

            Console.WriteLine("Think of a number between 1 and 10" + prompt);
            Console.ReadKey();

            Console.WriteLine("Multiply your number by " + fn + prompt);
            Console.ReadKey();

            Console.WriteLine("Multiply the result by " + sn + prompt);
            Console.ReadKey();

            Console.WriteLine("Divide the result by the number you originally thought of " + prompt);
            Console.ReadKey();

            Console.WriteLine("Subtract " + subtraction + prompt);
            Console.ReadKey();

            Console.WriteLine("The answer is " + answer);

        }
    }
}
