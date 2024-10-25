public class EternalGoal : Goal
{
    public EternalGoal(string description, int points) : base(description, points) { }

    public override int RecordEvent() => points;

    public override bool IsCompleted() => false;

    public override string DisplayProgress() => "[∞] No Completion";
}
