using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        // Declare the list.
        List<int> numbers = new List<int>();
        
        int inputNumber = -2;

        Console.WriteLine("Enter a series of numbers, and type 0 to finish.");

        while(inputNumber != 0)
        {
            // Prompt user to enter a series of numbers. 
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            inputNumber = int.Parse(userInput); 

            // Add user input number to numbers list.
            if (inputNumber != 0)
            {
                numbers.Add(inputNumber);
            }
        }

            // Compute the total sum.
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine($"The sum of the numbers is: {sum}");

            // Compute the average
            float average = ((float)sum)/numbers.Count;
            Console.WriteLine($"The average of the numbers is: {average}");

            // Find the largest number in the list.
            numbers.Sort(); // Sort numbers in ascending order.
            int largestNumber = numbers[numbers.Count - 1]; // Get the last number (largest number).

            // An alternative way of finding the largest number in the list
            /*largestNumber = numbers[0];

            foreach (int number in numbers)
            {
                if (number > largestNumber)
                {
                    // if this number is greater than the max, we have found the new max!
                    largestNumber = number;
                }
            } */
            Console.WriteLine($"The largest number is: {largestNumber}");    
        
    }
}