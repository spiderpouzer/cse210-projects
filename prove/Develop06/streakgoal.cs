public class StreakGoal : Goal
{
    private int currentStreak;
    private int streakPoints;

    public StreakGoal(string description, int points, int streakPoints)
        : base(description, points)
    {
        currentStreak = 0;
        this.streakPoints = streakPoints;
    }

    public override int RecordEvent()
    {
        currentStreak++;
        return points + (currentStreak * streakPoints);
    }

    public override bool IsCompleted() => false;

    public override string DisplayProgress() => $"Current Streak: {currentStreak}";

    public override string ToFileString() => $"{base.ToFileString()}|{currentStreak}|{streakPoints}";
}
