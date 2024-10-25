public class SimpleGoal : Goal
{
    private bool isCompleted;

    public SimpleGoal(string description, int points) : base(description, points)
    {
        isCompleted = false;
    }

    public override int RecordEvent()
    {
        if (!isCompleted)
        {
            isCompleted = true;
            return points;
        }
        return 0;
    }

    public override bool IsCompleted() => isCompleted;

    public override string DisplayProgress() => isCompleted ? "[X] Completed" : "[ ] Not Completed";

    public override string ToFileString() => $"{base.ToFileString()}|{isCompleted}";
}
