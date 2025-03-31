Season firstSeason = Season.Spring;
Season lastSeason = Season.Winter;
int firstSeasonAsNumber = (int)firstSeason;
int lastSeasonAsNumber = (int)lastSeason;
Console.WriteLine(firstSeason);
// casting to int works here because enums are actually ints under the hood
Console.WriteLine("As a number: " + firstSeasonAsNumber); // to display the index of this enum
Console.WriteLine(lastSeason);
Console.WriteLine("As a number: " + lastSeasonAsNumber); // to display the index of this enum

Car myCar = new Car("Tesla", "Model 3", 2022);
myCar.DisplayDetails();
myCar.StartEngine();

Console.ReadKey();

public enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}


public class Car
{
    // Properties with encapsulation
    public string Make { get; private set; }
    public string Model { get; private set; }
    public int Year { get; private set; }

    // Parameterized constructor to initialize properties
    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    // Instance method to display car details using the object's properties
    public void DisplayDetails()
    {
        Console.WriteLine($"Car details: \nMake: {Make} \nModel: {Model} \nYear: {Year}");
    }

    // Instance method to simulate starting the engine
    public void StartEngine()
    {
        Console.WriteLine("*starts engine*\n..vrooom vrooom!");
    }
}