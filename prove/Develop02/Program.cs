using System;

class Program
{
    static void Main(string[] args)
    {
        Entries entries1 = new Entries();
        Journal journal1 = new Journal();

        int userInput = -1;

        while (userInput != 5)
        {
            Console.WriteLine("\nWelcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            userInput = int.Parse(Console.ReadLine());

                if (userInput == 1)
                {
                    entries1.startProgram();
                }
                else if (userInput == 2)
                {
                    journal1.getEntry();
                }
                else if (userInput == 3)
                {
                    ConsoleWriteLine("Which file would you like to load?: ");
                    string loadFile = Console.ReadLine() + ".txt";
                    string[] lines = System.File.ReadAllLines(loadFile);
                    Console.WriteLine(" ");
                    Console.WriteLine("Journal Entry: ");
                    foreach (string line in lines)
                    {
                        string[] entry = line.Split(",");
                        string displayEntry = entry[0];
                        Console.WriteLine(displayEntry);
                    }
                }

                else if (userInput == 4)
                {
                    Console.WriteLine("What would you like to name your file?: ");
                    string userFile = Console.ReadLine();
                    string fileName = userFile + ".txt";
                    using (StreamWriter outputFile = new StreamWriter(fileName))
                    {
                    "I wish I could get this to work, but I have no idea what I'm doing on this step. I would love some feedback.";
                    }
                }
                else
                {
                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey();
                }
        }
    }
}