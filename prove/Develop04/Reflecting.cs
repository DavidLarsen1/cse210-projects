
// Reflection activity class
class ReflectionActivity : MindfulnessActivity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    // Constructor
    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    // Method to conduct reflection activity
    public void ConductActivity()
    {
        DisplayStartingMessage();

        Random random = new Random();

        string prompt = prompts[random.Next(prompts.Length)]; // Select random prompt
        Console.WriteLine(prompt);

        DateTime startTime = DateTime.Now;
        TimeSpan timeLimit = TimeSpan.FromSeconds(duration);
        TimeSpan elapsedTime = TimeSpan.Zero;

        foreach (string question in questions)
        {
            Console.Clear();
            Console.WriteLine(prompt);
            Console.WriteLine(question);
            elapsedTime = DateTime.Now - startTime;
            DisplaySpinner(5); // Display spinner while the question is shown
            if (elapsedTime >= timeLimit)
                break; // Exit the loop if time limit is reached
        }

        DisplayEndingMessage();
    }
}
