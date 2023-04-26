using System;

class Program
{
    static void Main(string[] args)
    {
        // Calling the functions 
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber  = PromptUserNumber();
        
        int numberSquared = SquareNumber(userNumber);

        DisplayResult(userName, numberSquared);

    }

        // Defining the functions.
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string fullname = Console.ReadLine();

            return fullname;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int favoriteNumber = int.Parse(Console.ReadLine());

            return favoriteNumber;

        }

        static int SquareNumber(int number)
        {
            int numberSquared = number * number;    // Compute the square of number

            return numberSquared;
        }

        static void DisplayResult(string fullname, int numberSquared)
        {
            Console.WriteLine($"{fullname}, the square of your number is {numberSquared}");
        }     
}