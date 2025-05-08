using ExtensionMethods.Extensions;

var multilineText = @"aaaa
bbbb
cccc
dddd";

Console.WriteLine("Count of lines is " + multilineText.CountLines());
Console.WriteLine("Count of lines is "
    + StringExtensions.CountLines(multilineText));

Console.ReadKey();

public static class RandomPizzaGenerator
{
    public static Pizza Generate(int howManyIngredients)
    {
        var pizza = new RandomPizzaGenerator();
        for (int i = 0; i < howManyIngredients; i++)
        {
            var randomIngredient = GenerateRandomIngredient();
            pizza.AddIngredient(randomIngredient);
        }
        return pizza;

    }
}