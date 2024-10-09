using System;
using System.Collections.Generic;

namespace YouTubeVideoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create 3-4 videos
            Video video1 = new Video("C# Basics", "TechWithTim", 300);
            Video video2 = new Video("OOP in C#", "CodeAcademy", 450);
            Video video3 = new Video("Data Structures in C#", "CS50", 600);

            // Add comments to each video
            video1.AddComment(new Comment("Alice", "This is really helpful!"));
            video1.AddComment(new Comment("Bob", "Thanks for the explanation."));
            video1.AddComment(new Comment("Charlie", "I learned a lot from this."));

            video2.AddComment(new Comment("Dave", "Very clear and concise."));
            video2.AddComment(new Comment("Eva", "Great examples!"));

            video3.AddComment(new Comment("Frank", "Fantastic breakdown of complex topics."));
            video3.AddComment(new Comment("Grace", "Great teaching style!"));

            // Store the videos in a list
            List<Video> videos = new List<Video> { video1, video2, video3 };

            // Iterate through each video and display the information
            foreach (var video in videos)
            {
                video.DisplayVideoInfo();
            }
        }
    }
}
