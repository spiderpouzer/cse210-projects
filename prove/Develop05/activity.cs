using System;
using System.Threading;

namespace MindfulnessApp
{
    public class Activity
    {
        protected int _duration;
        protected string _activityName;
        protected string _description;

        public Activity(string activityName, string description)
        {
            _activityName = activityName;
            _description = description;
        }

        public void StartActivity()
        {
            Console.WriteLine($"\n--- {_activityName} ---");
            Console.WriteLine(_description);
            Console.Write("Enter the duration of the activity in seconds: ");
            _duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Prepare to begin...");
            ShowSpinner(3);
        }

        public void EndActivity()
        {
            Console.WriteLine($"\nGood job! You've completed the {_activityName}.");
            Console.WriteLine($"Total time: {_duration} seconds.");
            ShowSpinner(3);
        }

        protected void ShowSpinner(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write("/");
                Thread.Sleep(500);
                Console.Write("\b\\");
                Thread.Sleep(500);
                Console.Write("\b");
            }
            Console.WriteLine();
        }

        protected void Countdown(int seconds)
        {
            while (seconds > 0)
            {
                Console.Write($"{seconds} ");
                Thread.Sleep(1000);
                seconds--;
            }
            Console.WriteLine();
        }
    }
}
