class Journal
{
    private List<Entry> entries;
    private List<string> prompts;

    public Journal()
    {
        entries = new List<Entry>();
        prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
    }

    public void WriteNewEntry()
    {
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine($"\n\n\nPrompt: {randomPrompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        Console.Write("\n\n\n");

        Entry entry = new Entry(randomPrompt, response);
        entries.Add(entry);
    }

    public void DisplayJournal()
    {
        if (entries.Count > 0)
        {
            foreach (var entry in entries)
            {
                Console.WriteLine($"\n\n\nDate: {entry.Date}");
                Console.WriteLine($"Prompt: {entry.Prompt}");
                Console.WriteLine($"Response: {entry.Response}\n\n\n");
            }
        }
        else
        {
            Console.WriteLine("\n\n\nNo entries to display. Please write a new entry or load a journal.\n\n\n");
        }
    }


    public void SaveJournal()
    {
        Console.Write("\n\n\nEnter the filename to save: ");
        string fileName = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response}");
            }
        }

        Console.WriteLine("\n\n\nJournal saved successfully.\n\n\n");
    }

    public void LoadJournal()
    {
        Console.Write("\n\n\nEnter the filename to load: ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            entries.Clear();

            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string[] parts = reader.ReadLine().Split(',');
                    if (parts.Length == 3)
                    {
                        Entry entry = new Entry(parts[0], parts[1], parts[2]);
                        entries.Add(entry);
                    }
                }
            }

            Console.WriteLine("\n\n\nJournal loaded successfully.\n\n\n");
        }
        else
        {
            Console.WriteLine("\n\n\nFile not found. Please check the filename and try again.\n\n\n");
        }
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}