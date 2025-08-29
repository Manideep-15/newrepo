using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 101); 
        int guess = 0;
        int attempts = 0;
        bool isValidInput = false;

        Console.WriteLine("Welcome to the Number Guessing Game!");
        Console.WriteLine("Guess the number between 1 and 100.");

        
        while (guess != secretNumber)
        {
            Console.Write("Enter your guess: ");
            string userInput = Console.ReadLine();

            
            isValidInput = int.TryParse(userInput, out guess);

            if (!isValidInput)
            {
                Console.WriteLine("Please enter a valid number.");
                continue; 
            }

            if (guess < 1 || guess > 100)
            {
                Console.WriteLine("Please guess a number between 1 and 100.");
                continue; 
            }

            attempts++; 

            if (guess < secretNumber)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else if (guess > secretNumber)
            {
                Console.WriteLine("Too high! Try again.");
            }
        }

        Console.WriteLine($"Congratulations! You've guessed the correct number {secretNumber} in {attempts} attempts.");
    }
}
