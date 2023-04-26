using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber, guess, count = 0; // Declare variables
        
        Random randomGenerator = new Random(); // Randomly generate magic number 
        magicNumber = randomGenerator.Next(1,100); // between 1 and 100.
         
            do
            {
                Console.Write("What is your guess? "); // Prompt for the guess
                string theGuess = Console.ReadLine();  // Read in the guess string
                guess = int.Parse(theGuess);           // Convert the string to integer
                count++;                               // Increment count
                if (magicNumber > guess)               // Check whether magic number is higher
                {
                    Console.WriteLine("Higher");       // Ask user to guess higher
                }
                else if (magicNumber < guess)          // Check whether magic number is lower
                {
                    Console.WriteLine("Lower");        // Ask user to guess lower         
                }

                else
                {
                    Console.WriteLine("You guessed it!");  // User entered the correct number
                }

            }
            while (magicNumber != guess);

            Console.WriteLine($"You have made {count} counts.");   // Display the number of counts   
    }
}