using System;
using System.Collections.Generic;


class Scripture
{
    private Reference reference;
    private string text;
    private List<Word> words;

    public Reference Reference { get { return reference; } }
    public string Text { get { return text; } }
    public bool AllWordsHidden { get { return words.TrueForAll(word => word.IsHidden); } }
    public List<Word> Words { get { return words; } }

    public Scripture(string reference, string text)
    {
        this.reference = new Reference(reference);
        this.text = text;
        words = InitializeWords();
    }

    private List<Word> InitializeWords()
    {
        List<Word> wordList = new List<Word>();

        string[] verseParts = text.Split(' ');
        foreach (string versePart in verseParts)
        {
            string wordText = versePart.Trim(new char[] { ',', '.', ';', ':', '!', '?' });
            Word word = new Word(wordText);
            wordList.Add(word);
        }

        return wordList;
    }

    public string GetHiddenText()
    {
        List<string> hiddenTextParts = new List<string>();

        foreach (Word word in words)
        {
            if (word.IsHidden)
                hiddenTextParts.Add(new string('_', word.Text.Length));
            else
                hiddenTextParts.Add(word.Text);
        }

        string hiddenText = string.Join(" ", hiddenTextParts);
        return $"{reference.Text}: {hiddenText}";
    }
}
