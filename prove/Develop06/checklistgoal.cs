public class ChecklistGoal : Goal
{
    public int TargetCount { get; private set; }
    public int TimesCompleted { get; private set; }
    public int BonusPoints { get; private set; }

    public ChecklistGoal(string description, int points, int targetCount, int bonusPoints)
        : base(description, points)
    {
        TargetCount = targetCount;
        TimesCompleted = 0;
        BonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        TimesCompleted++;
        if (TimesCompleted >= TargetCount)
        {
            return points + BonusPoints;
        }
        return points;
    }

    public override bool IsCompleted() => TimesCompleted >= TargetCount;

    public override string DisplayProgress() => $"Completed {TimesCompleted}/{TargetCount}";

    public override string ToFileString()
    {
        return $"{base.ToFileString()}|{TargetCount}|{TimesCompleted}|{BonusPoints}";
    }
}
