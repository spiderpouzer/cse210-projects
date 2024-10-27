using System;
using System.IO;

public abstract class Activity
{
    private DateTime _date;
    private int _durationMinutes;

    protected Activity(DateTime date, int durationMinutes)
    {
        _date = date;
        _durationMinutes = durationMinutes;
    }

    public DateTime Date => _date;
    public int DurationMinutes => _durationMinutes;

    public abstract double GetDistance(); // in kilometers or miles
    public abstract double GetSpeed(); // in kph or mph
    public abstract double GetPace(); // in minutes per km or mile

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {this.GetType().Name} ({_durationMinutes} min) - Distance: {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }

    // Method to write activity information to file
    public void WriteToFile(string filePath)
    {
        string summary = GetSummary();
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine(summary);
        }
    }
}
