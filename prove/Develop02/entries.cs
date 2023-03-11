using System;

public class Entries
{
    List<string> prompt = new List<string>();
    List<string> entriesList = new List<string>();
    int index;
    public Entries()
    {
        prompts.Add("What was the best part of your day today?");
        prompts.Add("What is one thing you didn't accomplish today that you want to accomplish in the future?");
        prompts.Add("What is something that you hope to happen today?");
        prompts.Add("What is one thing you think someone else would love today that you can do for them?");
    }

    public void startProgram()
    {
        getRandomPrompt();
        writeToFile();
    }

    public void getRandomPrompt()
    {
        Random randomPromp = new Random();
        int index = randomPromp.Next(prompts.Count);
        Console.WriteLine(prompts[index]);
        string userInput = Console.ReadLine();
        entriesList.Add(userInput);
    }

    public void writeToFile()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        string fileName = "myFile.txt";
        entriesList.Add(prompts[index]);
        entriesList.Add(dateText);
        using (StreamWriter outputFile = new StreamWriter(fileName));
    }

    public void Save()
    {
        List<string> saveEntries = entriesList;
        foreach (string saveEntry in saveEntries)
        {
            Console.WriteLine(saveEntry);
        }
    }
}