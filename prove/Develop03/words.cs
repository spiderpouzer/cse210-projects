// Word.cs
public class Word
{
    public string Text { get; private set; }
    private bool isHidden;

    public Word(string text)
    {
        Text = text;
        isHidden = false;
    }

    // Hide the word
    public void Hide()
    {
        isHidden = true;
    }

    // Show the word
    public void Show()
    {
        isHidden = false;
    }

    // Check if the word is hidden
    public bool IsHidden()
    {
        return isHidden;
    }

    // Display the word or underscores if hidden
    public override string ToString()
    {
        return isHidden ? "____" : Text;
    }
}
