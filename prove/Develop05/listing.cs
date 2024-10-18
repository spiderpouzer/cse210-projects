using System;

namespace MindfulnessApp
{
    public class ListingActivity : Activity
    {
        private string[] _prompts = {
            "List as many people that you appreciate.",
            "List as many personal strengths of yours.",
            "List as many people that you have helped this week."
        };

        public ListingActivity() : base("Listing Activity", "This activity helps you reflect on positive things by guiding you to list as many items as you can in a given area.")
        {
        }

        public void RunListingActivity()
        {
            StartActivity();

            Random random = new Random();
            string prompt = _prompts[random.Next(_prompts.Length)];
            Console.WriteLine($"\n{prompt}");

            Console.WriteLine("\nStart listing in...");
            Countdown(5);

            int itemsCount = 0;
            DateTime endTime = DateTime.Now.AddSeconds(_duration);

            while (DateTime.Now < endTime)
            {
                Console.Write("Enter an item: ");
                Console.ReadLine();
                itemsCount++;
            }

            Console.WriteLine($"\nYou listed {itemsCount} items.");
            EndActivity();
        }
    }
}
