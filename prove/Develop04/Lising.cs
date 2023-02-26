using System;
using System.Diagnostics;
public class ListingActivity : Activity
{
    private List<string> PromptList, answers;
    public ListingActivity() : base()
    {
        setName("Listing Activity");
        setDescription("This activity will help you see everything that's good in your life by letting you write down everything you can think of that is good in your life specifically");
        PromptList = new List<string>
        {
            "Who do you appreciate in your life the most?",
            "What are some needs you have that are being met at the moment?",
            "What are some good experiences you've had with the spirit lately?",
            "What's a task at work that you really enjoy right now?",
            "Who are some people in your life that you could go to that you look up to?"
        };

        answers = new List<string>();

    }

    public string getPrompt()
    {
        var randomPrompt = new Random();
        int index = randomPrompt.Next;
        return PromptList[index];
    }

    public void showRandomPrompt()
    {
        Console.WriteLine("List as many things you can think of per question please.");
        Console.WriteLine();

        _animation(5);

        completeCount = answerList.Count();

        completeCount++;
        
        Console.WriteLIne();
        Console.WriteLine($"you listed {count} items. Good job! I hope that this activity helped you a lot thorughout your day today.");
    }
}