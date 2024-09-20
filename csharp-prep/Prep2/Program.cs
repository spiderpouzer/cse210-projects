using System;

class Program
{
    static void Main()
    {
        //grade percentage
        Console.Write("Enter your grade percentage: ");
        int percentage = int.Parse(Console.ReadLine());

        //Declare a variable to hold the letter grade
        string letter;

        //letter grade based on the percentage
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Variable to hold the sign ("+", "-", or none)
        string sign = "";

        // Only assign "+" or "-" if the grade is not "A" or "F"
        if (letter != "A" && letter != "F")
        {
            int lastDigit = percentage % 10;

            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // Handle the case where A+ does not exist
        if (letter == "A" && percentage < 97)
        {
            sign = "-";
        }

        // Print the letter grade with the sign
        Console.WriteLine($"Your letter grade is: {letter} {sign}");

        // Check if the user passed or failed
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't give up! Better luck next time.");
        }
    }
}
