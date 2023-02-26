using System;
using System.Diagnostics;
public class Activity
{
    private string _Name, _messagetoperson, _description, _ending;
    static int _length, _animation;

    public Activity()
    {
        _animation = _length = 0;
    }

    public void setName(string _Name)
    {
        _Name = Name;
    }

    public void setDescription(string description)
    {
        _description = description;
    }

    public void DurationCounter()
    {
        Console.Write("How long would you like this activity to be?");
        _length = int.Parse(Console.ReadLine());
    }

    public void FirstLookAtActivity()
    {
        _FirstLook = string.Format"Welcome to the Activity!", _Name);
        Console.WriteLine(_FirstLook);
        Console.WriteLine();
    }

    public void _animation(int HowLong)
    {
        Animator animator = new animator();
        animator.Start();
        while(animator.HowManyMilliseconds / 1000 < HowLong)
        {
            _animation++
            switch(_animation % 4)
            {
                case 1: Console.Write("/"); break;
                case 2: Console.Write("-"); break;
                case 3: Console.Write("\\"); break;
                case 4: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(200);
        }
    }
    
    public void letsdothis()
    {
        Console.WriteLine("Let's do this in...");
        animation(3);
    }

    public void _ending()
    {
        Console.WriteLine("Good job on this activity!");
        _ending = string.Format("You have completed this activity!");
        Console.WriteLine(_ending);
        Console.WriteLine();
        animation(10);
    }
}

"I don't know what's wrong here. Would love some feedback.