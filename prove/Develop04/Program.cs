using System;
using System.Threading;

class MindfulnessActivity
{
    protected string name;
    protected string description;
    protected int duration;

    public MindfulnessActivity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    // To set duration
    public void SetDuration(int duration)
    {
        this.duration = duration;
    }

    // To display starting message
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {name} activity...");
        Console.WriteLine(description);
        Console.WriteLine($"Duration set to {duration} seconds.");
        Console.WriteLine("Hit enter to begin...");
        Console.ReadLine();
    }

    // Display ending message
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Congratulations! You've completed the activity.");
        Console.WriteLine($"You've completed the {name} activity for {duration} seconds.");
        Thread.Sleep(3000);
    }

    // Spinner animation
    protected void DisplaySpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/\b");
            Thread.Sleep(250);
            Console.Write("-\b");
            Thread.Sleep(250);
            Console.Write("\\\b");
            Thread.Sleep(250);
            Console.Write("|\b");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");

        // Menu
        Console.WriteLine("\nMenu:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");
        Console.Write("Choose an activity (1-4): ");

        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine("");

        switch (choice)
        {
            case 1:
                BreathingActivity breathingActivity = new BreathingActivity();
                Console.Write("Enter duration (in seconds): ");
                int duration1 = int.Parse(Console.ReadLine());
                breathingActivity.SetDuration(duration1);
                breathingActivity.ConductActivity();
                break;
            case 2:
                ReflectionActivity reflectionActivity = new ReflectionActivity();
                Console.Write("Enter duration (in seconds): ");
                int duration2 = int.Parse(Console.ReadLine());
                Console.Write("");
                reflectionActivity.SetDuration(duration2);
                reflectionActivity.ConductActivity();
                break;
            case 3:
                ListingActivity listingActivity = new ListingActivity();
                Console.Write("Enter duration (in seconds): ");
                int duration3 = int.Parse(Console.ReadLine());
                listingActivity.SetDuration(duration3);
                listingActivity.ConductActivity();
                break;
            case 4:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }
}
