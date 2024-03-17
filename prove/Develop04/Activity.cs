using System;

class Truck
{
    public string Make { get; }
    public string Model { get; }

    public Truck(string make, string model)
    {
        Make = make;
        Model = model;
    }
}

class Ford : Truck
{
    public Ford(string model) : base("Ford", model) { }

    public void Tow()
    {
        Console.WriteLine("Towing capacity: 10,000 lbs.");
    }
}
class Dodge : Truck
{
    public Dodge(string model) : base("Dodge", model) { }

    public void Haul()
    {
        Console.WriteLine("Hauling capacity: 1500 lbs.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Ford fordTruck = new Ford("F-150");
        Dodge dodgeTruck = new Dodge("RAM 1500");

        fordTruck.Drive();  // Output: Ford F-150 is driving.
        fordTruck.Tow();    // Output: Towing capacity: 10,000 lbs.

        dodgeTruck.Drive();  // Output: Dodge RAM 1500 is driving.
        dodgeTruck.Haul();   // Output: Hauling capacity: 1500 lbs.
    }
}
