// Scripture.cs
using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private ScriptureReference reference;
    private List<Word> words;

    public Scripture(ScriptureReference reference, string text)
    {
        this.reference = reference;
        words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    // Hide random words
    public void HideRandomWords(int count)
    {
        Random random = new Random();
        int wordsToHide = count;

        while (wordsToHide > 0)
        {
            int index = random.Next(words.Count);
            if (!words[index].IsHidden())
            {
                words[index].Hide();
                wordsToHide--;
            }
        }
    }

    // Check if all words are hidden
    public bool AreAllWordsHidden()
    {
        return words.All(w => w.IsHidden());
    }

    // Display the scripture with hidden words
    public void Display()
    {
        Console.WriteLine(reference.ToString());
        Console.WriteLine(string.Join(" ", words));
    }
}
