namespace MindfulnessApp
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you through breathing in and out slowly. Focus on your breathing.")
        {
        }

        public void RunBreathingActivity()
        {
            StartActivity();

            int breatheDuration = _duration / 2;
            for (int i = 0; i < breatheDuration; i++)
            {
                Console.WriteLine("Breathe in...");
                Countdown(3);
                Console.WriteLine("Breathe out...");
                Countdown(3);
            }

            EndActivity();
        }
    }
}
