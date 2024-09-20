using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Initialize the list to hold numbers
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int userInput;
        // Loop to get numbers from the user until they enter 0
        do
        {
            Console.Write("Enter number: ");
            userInput = int.Parse(Console.ReadLine());

            if (userInput != 0)
            {
                numbers.Add(userInput);  // Append to the list
            }

        } while (userInput != 0);

        // Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        // Compute the average
        double average = (double)sum / numbers.Count;

        // Find the maximum number
        int max = int.MinValue;
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        // Find the smallest positive number
        int smallestPositive = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }

        // Sort the list
        numbers.Sort();

        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The average is: " + average);
        Console.WriteLine("The largest number is: " + max);

        // Check if smallest positive number was found
        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine("The smallest positive number is: " + smallestPositive);
        }
        else
        {
            Console.WriteLine("There are no positive numbers.");
        }

        // Print the sorted list
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
