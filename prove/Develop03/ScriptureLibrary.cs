using System;

class ScriptureLibrary
{
    private List<Scripture> scriptures;
    private Random random;

    public ScriptureLibrary(string[] texts)
    {
        this.scriptures = new List<Scripture>();
        this.random = new Random();
        foreach (string text in texts)
        {
            string[] parts = text.Split(new[] { ": " }, StringSplitOptions.None);
            this.scriptures.Add(new Scripture(parts[0], parts[1]));
        }
    }

    public void RandomScripture()
    {
        Scripture scripture = this.scriptures[this.random.Next(this.scriptures.Count)];
        while (scripture.HideRandomWord())
        {
            scripture.Display();
            Console.ReadLine();
        }
    }
}