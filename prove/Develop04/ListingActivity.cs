using System;
using System.Threading;

namespace ActivityProgram
{
    class ListingActivity : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    
    public ListingActivity(int duration) : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration)
    {
    }
    
    public override void Run()
    {
        base.Run();

        int count = 0;

        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine($"Prompt: {prompt}");

        Console.WriteLine("You have 10 seconds to think before you start listing.");
        for (int i = 10; i >= 1; i--)
        {
            Console.Write($"{i}...");
            Thread.Sleep(1000);
        }
        Console.WriteLine("Go!");

        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(item))
            {
                continue;
            }
            count++;
        }

        Console.WriteLine($"You listed {count} items!");

        base.End();
    }
}
}