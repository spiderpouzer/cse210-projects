using System;
using System.Collections.Generic;

namespace YouTubeVideoApp
{
    public class Video
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Length { get; set; } // Length in seconds
        private List<Comment> comments = new List<Comment>();

        public Video(string title, string author, int length)
        {
            Title = title;
            Author = author;
            Length = length;
        }

        // Method to add a comment to the video
        public void AddComment(Comment comment)
        {
            comments.Add(comment);
        }

        // Method to return the number of comments
        public int GetNumberOfComments()
        {
            return comments.Count;
        }

        // Method to display video information and comments
        public void DisplayVideoInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Length: {Length} seconds");
            Console.WriteLine($"Number of comments: {GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (var comment in comments)
            {
                Console.WriteLine($"  - {comment}");
            }
            Console.WriteLine(); // For a new line after each video
        }
    }
}
