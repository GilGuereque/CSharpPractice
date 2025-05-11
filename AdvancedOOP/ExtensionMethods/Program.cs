using ExtensionMethods.Extensions;

var multilineText = @"aaaa
bbbb
cccc
dddd";

Console.WriteLine("Count of lines is " + multilineText.CountLines());
Console.WriteLine("Count of lines is "
    + StringExtensions.CountLines(multilineText));

Console.WriteLine("Next after Spring is " + Season.Spring.Next());
Console.WriteLine("Next after Winter is " + Season.Winter.Next());


Console.ReadKey();

//// Coding Exercise solution:
//using System;

//namespace Coding.Exercise
//{
//    public static class ListExtensions
//    {
//        public static List<int> TakeEverySecond(this List<int> list)
//        {
//            List<int> result = new List<int>();
//            for (int i = 0; i < list.Count; i += 2)
//            {
//                result.Add(list[i]);
//            }
//            return result;
//        }
//    }
//}

//abstract error example
var bakableDishes = new List<IBakeable>
{
    new Pizza(),
    new Panettone()
};

foreach (var bakableDish in bakableDishes)
{
Console.WriteLine(bakableDish.GetInstructions());
}

public abstract class Dessert { }

public interface IBakeable
{
    string GetInstructions();
}

public class Panettone : Dessert, IBakeable
{
    public string GetInstructions() =>
        Console.WriteLine("Bake at 180 degrees celsius for 35 minutes.");
}

public class Pizza : IBakeable
{
    public string GetInstructions() =>
        Console.WriteLine("Bake at 250 degrees celsius for 10 minutes, " +
            "ideally on a stone");
}
