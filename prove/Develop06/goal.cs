using System;

public abstract class Goal
{
    protected string description;
    protected int points;

    public Goal(string description, int points)
    {
        this.description = description;
        this.points = points;
    }

    public abstract int RecordEvent();
    public abstract bool IsCompleted();
    public abstract string DisplayProgress();

    public virtual string ToFileString()
    {
        return $"{GetType().Name}|{description}|{points}";
    }

    public string Description => description;
}
