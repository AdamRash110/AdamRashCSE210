using System;

class Scripture
{
    private string reference;
    private List<string> verses;
    private List<bool> hiddenWords;

    public Scripture(string reference, string text)
    {
        this.reference = reference;
        this.verses = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        this.hiddenWords = Enumerable.Repeat(false, this.verses.Count).ToList();
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(this.reference);
        for (int i = 0; i < this.verses.Count; i++)
        {
            if (this.hiddenWords[i])
            {
                Console.Write(new string('*', this.verses[i].Length) + " ");
            }
            else
            {
                Console.Write(this.verses[i] + " ");
            }
        }
        Console.WriteLine();
    }

    public bool HideRandomWord()
    {
        int index = this.hiddenWords.FindIndex(x => !x);
        if (index == -1)
        {
            return false;
        }
        this.hiddenWords[index] = true;
        return true;
    }
}