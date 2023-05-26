using System;
using System.Collections.Generic;


class Word
{
    private string text;
    private bool isHidden;

    public string Text { get { return text; } }
    public bool IsHidden { get { return isHidden; } }

    public Word(string text)
    {
        this.text = text;
        isHidden = false;
    }

    public void Hide()
    {
        isHidden = true;
    }
}