// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a scripture reference and scripture text
        ScriptureReference reference = new ScriptureReference("Proverbs", "3", "5", "6");
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding in all thy ways acknowledge him and he shall direct thy paths.";

        // Create scripture object
        Scripture scripture = new Scripture(reference, text);

        // Display initial scripture
        Console.Clear();
        scripture.Display();

        // Start hiding words
        while (true)
        {
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3); // Hide 3 words at a time
            Console.Clear();
            scripture.Display();

            if (scripture.AreAllWordsHidden())
            {
                Console.WriteLine("All words are hidden! Good job!");
                break;
            }
        }
    }
}
