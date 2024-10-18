using System;

namespace MindfulnessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nMindfulness Activities Menu:");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Quit");

                Console.Write("Choose an activity (1-4): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        BreathingActivity breathing = new BreathingActivity();
                        breathing.RunBreathingActivity();
                        break;

                    case "2":
                        ReflectionActivity reflection = new ReflectionActivity();
                        reflection.RunReflectionActivity();
                        break;

                    case "3":
                        ListingActivity listing = new ListingActivity();
                        listing.RunListingActivity();
                        break;

                    case "4":
                        running = false;
                        Console.WriteLine("Exiting program.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select 1-4.");
                        break;
                }
            }
        }
    }
}
