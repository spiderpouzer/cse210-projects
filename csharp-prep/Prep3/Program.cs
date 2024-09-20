using System;

class Program
{
    static void Main()
    {
        string playAgain = "yes";

        // Loop to allow playing multiple games
        while (playAgain.ToLower() == "yes")
        {
            // Generate a random magic number between 1 and 100
            Random random = new Random();
            int magicNumber = random.Next(1, 101);

            int guess = -1;  // Initialize guess variable
            int guessCount = 0;  // Counter for number of guesses

            // Keep looping until the guess matches the magic number
            while (guess != magicNumber)
            {
                // Ask the user for their guess
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;  // Increment the guess counter

                // Determine if the guess is too high, too low, or correct
                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }
            }

            // Ask if they want to play again
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        }

        // Game ends
        Console.WriteLine("Thank you for playing!");
    }
}

    
