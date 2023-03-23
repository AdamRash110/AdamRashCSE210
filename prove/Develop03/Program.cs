using System;

class Program
{
    static void Main()
    {
        string[] texts = {
            "John 3:16: For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.",
            "Proverbs 3:5-6: Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.",
            "Psalm 23:1: The LORD is my shepherd; I shall not want.",
            "Matthew 6:33: But seek ye first the kingdom of God, and his righteousness; and all these things shall be added unto you."
        };
        ScriptureLibrary library = new ScriptureLibrary(texts);
        while (true)
        {
            library.RandomScripture();
            Console.WriteLine("Press enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
        }
    }
}