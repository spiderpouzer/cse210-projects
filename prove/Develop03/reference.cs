// ScriptureReference.cs
public class ScriptureReference
{
    public string Book { get; private set; }
    public string Chapter { get; private set; }
    public string StartVerse { get; private set; }
    public string EndVerse { get; private set; }

    // Constructor for single verse
    public ScriptureReference(string book, string chapter, string startVerse)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = null;
    }

    // Constructor for verse range
    public ScriptureReference(string book, string chapter, string startVerse, string endVerse)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    // Display reference as string
    public override string ToString()
    {
        if (EndVerse == null)
        {
            return $"{Book} {Chapter}:{StartVerse}";
        }
        else
        {
            return $"{Book} {Chapter}:{StartVerse}-{EndVerse}";
        }
    }
}
