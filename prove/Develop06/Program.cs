using System;

class Program
{
    private static GoalManager goalManager = new GoalManager();

    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- Eternal Quest ---");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Record an event");
            Console.WriteLine("3. Show goals");
            Console.WriteLine("4. Save goals to file");
            Console.WriteLine("5. Load goals from file");
            Console.WriteLine("6. Show score and level");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    goalManager.ShowGoals();
                    break;
                case "4":
                    goalManager.SaveGoalsToFile();
                    break;
                case "5":
                    goalManager.LoadGoalsFromFile();
                    break;
                case "6":
                    goalManager.ShowScoreAndLevel();
                    break;
                case "0":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    private static void CreateGoal()
    {
        Console.WriteLine("Select the goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Streak Goal");
        Console.Write("Choose an option: ");
        string choice = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        Goal goal = choice switch
        {
            "1" => new SimpleGoal(description, points),
            "2" => new EternalGoal(description, points),
            "3" => CreateChecklistGoal(description, points),
            "4" => CreateStreakGoal(description, points),
            _ => null
        };

        if (goal != null)
        {
            goalManager.CreateGoal(goal);
        }
        else
        {
            Console.WriteLine("Invalid option.");
        }
    }

    private static ChecklistGoal CreateChecklistGoal(string description, int points)
    {
        Console.Write("Enter target count: ");
        int targetCount = int.Parse(Console.ReadLine());
        Console.Write("Enter bonus points: ");
        int bonusPoints = int.Parse(Console.ReadLine());
        return new ChecklistGoal(description, points, targetCount, bonusPoints);
    }

    private static StreakGoal CreateStreakGoal(string description, int points)
    {
        Console.Write("Enter streak bonus points: ");
        int streakPoints = int.Parse(Console.ReadLine());
        return new StreakGoal(description, points, streakPoints);
    }

    private static void RecordEvent()
    {
        Console.WriteLine("Select a goal to record an event for:");
        goalManager.ShowGoals();
        int choice = int.Parse(Console.ReadLine()) - 1;
        goalManager.RecordEvent(choice);
    }
}
