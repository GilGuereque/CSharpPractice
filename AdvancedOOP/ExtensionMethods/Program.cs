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
