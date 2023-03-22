using System;
using System.Threading;

namespace ActivityProgram
{
    abstract class Activity
    {
        protected int duration;
        protected string name;
        protected string description;

        protected Activity()
        {
            this.name = "Unknown Activity";
            this.description = "No description provided.";
            this.duration = 0;
        }

        protected Activity(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        protected void ShowStartingMessage()
        {
            Console.WriteLine("Starting " + name);
            Console.WriteLine(description);
            Console.WriteLine("Please enter the duration in seconds: ");
            duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Get ready to begin in: ");
            for (int i = 3; i >= 1; i--)
            {
                Console.Write(i + "...");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Go!");
        }

        protected void ShowEndingMessage()
        {
            Console.WriteLine("Good job! You have completed " + name + " for " + duration + " seconds.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public abstract void Start();
    }
}