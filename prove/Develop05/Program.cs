using System;
using System.Collections.Generic;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Goal> goals = new List<Goal>();
            int currentScore = 0;
            goals.Add(new SimpleGoal("Run a marathon", 1000));
            goals.Add(new EternalGoal("Read scriptures", 100));
            goals.Add(new ChecklistGoal("Attend the temple", 50, 10));

            while (true)
            {
                Console.WriteLine("Enter a command (new, record, list, score, exit):");
                string input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "new":
                        Console.WriteLine("Enter goal type (simple, eternal, checklist):");
                        string type = Console.ReadLine().ToLower();

                        Console.WriteLine("Enter goal name:");
                        string name = Console.ReadLine();

                        Console.WriteLine("Enter point value:");
                        int value = int.Parse(Console.ReadLine());

                        switch (type)
                        {
                            case "simple":
                                goals.Add(new SimpleGoal(name, value));
                                break;
                            case "eternal":
                                goals.Add(new EternalGoal(name, value));
                                break;
                            case "checklist":
                                Console.WriteLine("Enter number of items to complete:");
                                int target = int.Parse(Console.ReadLine());
                                goals.Add(new ChecklistGoal(name, value, target));
                                break;
                        }
                        break;

                    case "record":
                        Console.WriteLine("Enter goal name:");
                        string goalName = Console.ReadLine();
                    Goal goalToRecord = null;
                    foreach (Goal goal in goals)
                    {
                        if (goal.Name.ToLower() == goalName.ToLower())
                        {
                            goalToRecord = goal;
                            break;
                        }
                    }

                    if (goalToRecord != null)
                    {
                        goalToRecord.RecordEvent();
                        currentScore += goalToRecord.Score;
                        Console.WriteLine($"Recorded event for {goalToRecord.Name}. You earned {goalToRecord.Score} points.");
                    }
                    else
                    {
                        Console.WriteLine($"Could not find a goal with the name {goalName}.");
                    }
                    break;

                case "list":
                    Console.WriteLine("Goals:");
                    foreach (Goal goal in goals)
                    {
                        string status = goal.IsComplete() ? "[X]" : "[ ]";
                        Console.WriteLine($"{status} {goal.Name} - {goal.GetStatus()}");
                    }
                    break;

                case "score":
                    Console.WriteLine($"Your current score is {currentScore}.");
                    break;

                case "exit":
                    return;

                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}
}