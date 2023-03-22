using System;
using System.Threading;

namespace ActivityProgram
{
        class BreathingActivity : Activity
    {
        public BreathingActivity() : base("Breathing Exercise", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
        {
        }

        public override void Start()
        {
            ShowStartingMessage();
            int timeRemaining = duration;
            while (timeRemaining > 0)
            {
                Console.WriteLine("Breathe in...");
                Thread.Sleep(2000);
                Console.WriteLine("Breathe out...");
                Thread.Sleep(2000);
                timeRemaining -= 4;
            }
            ShowEndingMessage();
        }
    }
}