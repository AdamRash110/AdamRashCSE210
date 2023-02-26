using System;
using System.Diagnostics;
public class ReflectingActivity : Activity
{
    private List<string> _Prompts, _PonderingsForYourself;
    public ReflectingActivity() : base()
    {
        setName("Reflection Activity");
        setDescription("It's time for the activity in which you will reflect upon yourself and what you have done in your life that has lots of meaning.");

        _Prompts = new List<string>
        {
            "Think of how you are financially",
            "Think of how you are spiritually",
            "Think of if you like the job or career you have currently",
            "Think of a time when you did something for someone",
            "Think of the last thing a person said to you that made you happy"
        };
        
        _PonderingsForYourself = new List<string>
        {
            "What has this activity done so far for you?",
            "How can you benefit your future life with this activity?",
            "What made this activity different so far than other activities you've participated in?",
            "What about you are you going to change because of this activity",
            "Are there any loved ones in your life that you can refer this activity to that would benefit from it?"
        };

        public string RandomPrompt()
        {
            var randomPrompt = new Random();
            int index = randomPrompt.Next;
            return _Prompts[index];
        }

        public void displayPrompt()
        {
            Console.WriteLine("Think to yourself the following questions: ");
            Console.WriteLine();
            Console.WriteLine("When you think of something, continue to the next prompt please");
            Console.ReadLine();
        }

        public void displayPonderingsForYourself()
        {
            Console.WriteLine("Now ponder to yourself the next following questions about the activity you just participated in: ");
            Console.WriteLine();
        }
    }
}