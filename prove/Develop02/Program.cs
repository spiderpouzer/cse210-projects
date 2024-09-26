using System;
using System.Collections.Generic;

class Program
{
    static List<string> _prompts = new List<string>
    {
        "Who is the most important person you saw today?",
        "How do you feel today?",
        "What are you grateful for today?",
        "What do you like to do today?",
        "How are your emotions today?"
    };

    static Journal _journal = new Journal();

    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    WriteNewEntry();
                    break;
                case 2:
                    _journal.DisplayJournal();
                    break;
                case 3:
                    SaveJournal();
                    break;
                case 4:
                    LoadJournal();
                    break;
            }

        } while (choice != 5);
    }

    static void WriteNewEntry()
    {
        // Pick a random prompt
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        
        // Get the user's response
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        // Create a new entry and add to the journal
        Entry entry = new Entry(prompt, response);
        _journal.AddEntry(entry);
    }

    static void SaveJournal()
    {
        Console.Write("Enter the filename to save to: ");
        string filename = Console.ReadLine();
        _journal.SaveToFile(filename);
    }

    static void LoadJournal()
    {
        Console.Write("Enter the filename to load from: ");
        string filename = Console.ReadLine();
        _journal.LoadFromFile(filename);
    }
}
