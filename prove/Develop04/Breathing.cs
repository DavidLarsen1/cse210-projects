
// Breathing activity class
class BreathingActivity : MindfulnessActivity
{
    // Constructor
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    // Method to conduct breathing activity
    public void ConductActivity()
    {
        DisplayStartingMessage();


        int totalCycles = duration / 10;

        for (int cycle = 1; cycle <= totalCycles; cycle++)
        {
            Console.WriteLine($"Cycle {cycle}/{totalCycles}: Breath in");
            Countdown(5);

            Console.WriteLine($"Cycle {cycle}/{totalCycles}: Breathe out...");
            Countdown(5);

        }

        DisplayEndingMessage();
    }

    // Method to display countdown
    private void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
            Console.Write("\b\b\b");
        }
        Console.Write("\b\b");
        // Console.WriteLine();
    }
}
