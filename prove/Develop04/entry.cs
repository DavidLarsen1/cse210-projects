class Entry
{
    public string Date { get; }
    public string Prompt { get; }
    public string Response { get; }

    public Entry(string prompt, string response)
    {
        Date = DateTime.Now.ToString();
        Prompt = prompt;
        Response = response;
    }

    public Entry(string date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }
}