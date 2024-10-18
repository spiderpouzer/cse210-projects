using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    public class ReflectionActivity : Activity
    {
        private List<string> _prompts = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private List<string> _questions = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What did you learn about yourself through this experience?"
        };

        public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you showed strength and resilience.")
        {
        }

        public void RunReflectionActivity()
        {
            StartActivity();

            Random random = new Random();
            string prompt = _prompts[random.Next(_prompts.Count)];
            Console.WriteLine($"\n{prompt}");

            for (int i = 0; i < _duration / 5; i++) // Show one question every 5 seconds
            {
                string question = _questions[random.Next(_questions.Count)];
                Console.WriteLine($"\n{question}");
                ShowSpinner(5);
            }

            EndActivity();
        }
    }
}
