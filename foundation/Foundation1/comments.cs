using System;

namespace YouTubeVideoApp
{
    public class Comment
    {
        public string CommenterName { get; set; }
        public string CommentText { get; set; }

        public Comment(string commenterName, string commentText)
        {
            CommenterName = commenterName;
            CommentText = commentText;
        }

        // Override the ToString() method to display the comment details
        public override string ToString()
        {
            return $"{CommenterName}: {CommentText}";
        }
    }
}
