using ExtensionMethods.Extensions;

var multilineText = @"aaaa
bbbb
cccc
dddd";

Console.WriteLine("Count of lines is " + multilineText.CountLines());
Console.WriteLine("Count of lines is "
    + StringExtensions.CountLines(multilineText));

Console.WriteLine("Next after spring is " + Season.Spring.Next());
Console.WriteLine("Next after winter is " + Season.Winter.Next());

Console.ReadKey();
