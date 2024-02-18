
using System;

class Program {
    static void Main(string[] args) {
        Scripture scripture = new Scripture("Proverbs 3:5-6", "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        while (!scripture.AllWordsHidden()) {
            Console.Clear();
            scripture.Display();

            Console.WriteLine("Press enter to continue or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit") {
                Console.Clear();
                break;
            }

            scripture.HideRandomWords();
        }

        Console.WriteLine("Program ended.");
    }
}


























