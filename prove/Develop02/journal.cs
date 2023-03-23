using System;

class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(string prompt)
    {
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        Entry entry = new Entry(DateTime.Now, prompt, response);
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine($"{entry.Date} - {entry.Prompt}: {entry.Response}");
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            while (!reader.EndOfStream)
            {
                string[] line = reader.ReadLine().Split(',');
                DateTime date = DateTime.Parse(line[0]);
                string prompt = line[1];
                string response = line[2];
                Entry entry = new Entry(date, prompt, response);
                entries.Add(entry);
            }
        }
    }
}