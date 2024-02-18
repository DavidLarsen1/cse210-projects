class Car
{
    private string make
    private string model

    public Car(string make, string model)
    {
        this.make = make;
        this.model = model;
    }

    private string Display() {
        return $"{make} {model}";
    }

    public string PublicDisplay() {
        return Display()
    }

    public string GetMake()
    {
        return make;
    }

    public void SetMake(string newMake) {
        System.console.WriteLine();
        make = newMake;
    }
}