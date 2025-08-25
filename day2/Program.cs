using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int secretNumber = rand.Next(1, 101);
        int guess;

        do
        {
            Console.Write("Guess the number between 1 and 100: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out guess))
            {
                if (guess < secretNumber)
                    Console.WriteLine("Too low!");
                else if (guess > secretNumber)
                    Console.WriteLine("Too high!");
                else
                    Console.WriteLine("Correct! You guessed it.");
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        } while (guess != secretNumber);
    }
}
