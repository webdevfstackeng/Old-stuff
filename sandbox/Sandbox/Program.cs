using System;

class Program
{
    static void Main(string[] args)
    {
       /* string response = "yes";

        while (response == "yes")
        {
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        } */

        //do-while loop
        /*string response;
        do
        {
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        } while (response == "yes"); */

        // For loop
        /*for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        } */
        
        // foreach(string color in colors)
        // {
        //     Console.WriteLine(color);
        // }
        // Random randomGenerator = new Random();
        // int number = randomGenerator.Next(1,11);
        List<int> numbers = new List<int>();
        numbers.Add(4);
        numbers.Add(5);
        numbers.Add(1);

        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }

    }
}