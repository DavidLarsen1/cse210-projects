
// Listing activity class
class ListingActivity : MindfulnessActivity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    // Constructor
    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    // Method to conduct listing activity
    public void ConductActivity()
    {
        DisplayStartingMessage();

        Random random = new Random();

        string prompt = prompts[random.Next(prompts.Length)]; // Select random prompt
        Console.WriteLine(prompt);

        Console.WriteLine("You have 10 seconds to begin listing...");
        
        DateTime startTime = DateTime.Now;
        TimeSpan timeLimit = TimeSpan.FromSeconds(duration);
        TimeSpan elapsedTime = TimeSpan.Zero;
        List<string> itemsListed = new List<string>();

        while (elapsedTime < timeLimit)
        {
            if (Console.KeyAvailable)
            {
                string userInput = Console.ReadLine();
                if (userInput.ToLower() == "done")
                    break;
                itemsListed.Add(userInput);
            }

            elapsedTime = DateTime.Now - startTime;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write($"");
            Thread.Sleep(100); // Check for user input every 100 milliseconds
        }

        Console.WriteLine("\nTime's up!");
        Console.WriteLine();
        Console.WriteLine($"You listed {itemsListed.Count} items within the time limit:");
        Console.WriteLine();
        DisplayEndingMessage();
    }
}
