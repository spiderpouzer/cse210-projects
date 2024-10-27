using System;
using System.Collections.Generic;
using System.Globalization;

public class Program
{
    public static void Main()
    {
        // Define file path
        string filePath = "activities.txt";
        List<Activity> activities = new List<Activity>();

        // Ask the user how many activities they want to enter
        Console.Write("How many activities would you like to enter? ");
        if (!int.TryParse(Console.ReadLine(), out int numActivities) || numActivities < 1)
        {
            Console.WriteLine("Please enter a valid number of activities.");
            return;
        }

        // Loop to collect each activity
        for (int i = 0; i < numActivities; i++)
        {
            Console.WriteLine($"\nEnter details for activity #{i + 1}");

            // Select activity type
            Console.WriteLine("Choose activity type (1 - Running, 2 - Cycling, 3 - Swimming): ");
            string activityType = Console.ReadLine();

            // Input shared properties
            DateTime date;
            Console.Write("Enter the date (yyyy-mm-dd): ");
            while (!DateTime.TryParseExact(Console.ReadLine(), "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                Console.Write("Invalid date format. Enter the date (yyyy-mm-dd): ");
            }

            Console.Write("Enter the duration in minutes: ");
            if (!int.TryParse(Console.ReadLine(), out int duration) || duration < 1)
            {
                Console.WriteLine("Invalid duration. Must be a positive integer.");
                continue;
            }

            // Input specific properties based on activity type
            Activity activity = null;
            switch (activityType)
            {
                case "1": // Running
                    Console.Write("Enter the distance in kilometers: ");
                    if (double.TryParse(Console.ReadLine(), out double distanceKm))
                    {
                        activity = new Running(date, duration, distanceKm);
                    }
                    else
                    {
                        Console.WriteLine("Invalid distance. Must be a number.");
                    }
                    break;

                case "2": // Cycling
                    Console.Write("Enter the speed in km/h: ");
                    if (double.TryParse(Console.ReadLine(), out double speedKph))
                    {
                        activity = new Cycling(date, duration, speedKph);
                    }
                    else
                    {
                        Console.WriteLine("Invalid speed. Must be a number.");
                    }
                    break;

                case "3": // Swimming
                    Console.Write("Enter the number of laps: ");
                    if (int.TryParse(Console.ReadLine(), out int laps))
                    {
                        activity = new Swimming(date, duration, laps);
                    }
                    else
                    {
                        Console.WriteLine("Invalid number of laps. Must be an integer.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid activity type. Please select 1, 2, or 3.");
                    continue;
            }

            // Add activity to list if it was created successfully
            if (activity != null)
            {
                activities.Add(activity);
                Console.WriteLine("Activity added successfully.");
            }
        }

        // Display the summary for each activity and save it to file
        Console.WriteLine("\nActivity Summaries:");
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            activity.WriteToFile(filePath);
        }

        Console.WriteLine($"\nAll activities have been written to {filePath}");
    }
}
