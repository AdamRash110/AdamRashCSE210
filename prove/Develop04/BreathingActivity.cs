using System;
using System.Diagnostics;
public class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        setName("Breathing Activity");
        setDescription("This activity is going to help you relax by helping you breath slowly.");
    }

    public void setCounterForBreathing(int numSeconds)
    {
        for (int i = 1; i<= numSeconds; i++)
        {
            Console.WriteLine(string.Format("{0}"));
            Thread.Sleep(1000);
        }
    }

    public void instructionsforbreathing()
    {
        int Timeforbreathing = getusertime();
        Animator animator = new Animator();
        animator.Start();
        while(animator.HowManyMilliseconds / 1000 < Timeforbreathing)
        {
            Console.Write("Breath in");
            setCounterForBreathing(5);

            Console.WriteLine();

            Console.WriteLine("Breathe out");
            setCounterForBreathing(5);

            Console.WriteLine();
        }
    }
}

"I don't know what's wrong here. Would love some feedback.