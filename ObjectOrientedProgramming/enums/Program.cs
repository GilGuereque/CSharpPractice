Season firstSeason = Season.Spring;
Season lastSeason = Season.Winter;
int firstSeasonAsNumber = (int)firstSeason;
int lastSeasonAsNumber = (int)lastSeason;
Console.WriteLine(firstSeason);
// casting to int works here because enums are actually ints under the hood
Console.WriteLine("As a number: " + firstSeasonAsNumber); // to display the index of this enum
Console.WriteLine(lastSeason);
Console.WriteLine("As a number: " + lastSeasonAsNumber); // to display the index of this enum
Console.ReadKey();

public enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}