using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? " ); // prompt for first name
        string firstName = Console.ReadLine(); // Read first name
        
        Console.Write("What is your last name? "); // prompt for last name
        string lastName = Console.ReadLine(); // Read last name

        Console.WriteLine(); // Leave space for readability

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}."); // Output fullname to console
    }
}