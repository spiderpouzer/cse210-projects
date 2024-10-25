using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> goals;
    private int score;
    private const string FilePath = "goals.txt";

    public GoalManager()
    {
        goals = new List<Goal>();
        score = 0;
        LoadGoalsFromFile();
    }

    public void CreateGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            score += goals[goalIndex].RecordEvent();
            Console.WriteLine("Event recorded. Score updated.");
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    public void ShowGoals()
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Description} - {goals[i].DisplayProgress()}");
        }
    }

    public void ShowScoreAndLevel()
    {
        int level = score / 1000;
        Console.WriteLine($"Current score: {score}");
        Console.WriteLine($"Level: {level} - Level up every 1000 points!");
    }

    public void SaveGoalsToFile()
    {
        using (StreamWriter writer = new StreamWriter(FilePath))
        {
            writer.WriteLine(score);
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.ToFileString());
            }
        }
        Console.WriteLine("Goals saved to file.");
    }

    public void LoadGoalsFromFile()
    {
        if (!File.Exists(FilePath)) return;

        goals.Clear();
        using (StreamReader reader = new StreamReader(FilePath))
        {
            score = int.Parse(reader.ReadLine());
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                string goalType = parts[0];
                string description = parts[1];
                int points = int.Parse(parts[2]);

                Goal goal = goalType switch
                {
                    "SimpleGoal" => new SimpleGoal(description, points),
                    "EternalGoal" => new EternalGoal(description, points),
                    "ChecklistGoal" => new ChecklistGoal(description, points, int.Parse(parts[3]), int.Parse(parts[4])),
                    "StreakGoal" => new StreakGoal(description, points, int.Parse(parts[3])),
                    _ => null
                };

                if (goal != null) goals.Add(goal);
            }
        }
        Console.WriteLine("Goals loaded successfully.");
    }
}
