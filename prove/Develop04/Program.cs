using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my program to the you can feel self-happy again!");
        Console.WriteLine();

        int YourChoice = 0;

        List<string> menu = new List<string>
        {
            "Menu Options:",
            "1. Start the breathing activity I have made for you!",
            "2. Start the reflecting activity I have made for you!",
            "3. Start the listing activity I have made for you!",
            "4. Quit"
        };
        foreach(string option in menu)
            {
                "Couldnt figure out what to put here to make this code work completely. Would love feedback."
            }
            }
            Console.WriteLine("Choose an option please");
            YourChoice = int.Parse(Console.ReadLine());
            switch (YourChoice)
            {
                case 1:
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.breathingprogram();
                break;

                case 2:
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.reflectingprogram();
                break;

                case 3:
                    ListingActivity listing = new ListingActivity();
                    listing.listingprogram();
                break;
            }
        }
    }
}

"I don't know what's wrong here. Would love some feedback.