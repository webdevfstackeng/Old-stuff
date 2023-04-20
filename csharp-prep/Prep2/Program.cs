using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string gradePercentage = Console.ReadLine();
        int response = int.Parse(gradePercentage);
        string letter = "";

        if (response >= 90)
        {
            letter = "A";
        }

        else if (response >= 80)
        {
            letter = "B";
        }

        else if (response >= 70)
        {
            letter = "C";
        }

        else if (response >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"You got grade {letter}.");

        if (response >= 70)
        {
            Console.WriteLine($"Congratulations!! You passed.");
        }

        else
        {
            Console.WriteLine("Sorry you could not make it. Good luck next time.");
        }



    }
}