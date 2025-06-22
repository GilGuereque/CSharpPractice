// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int userCheck = 2;

try
{
    if (userCheck == 1)
    {
        Console.WriteLine("The first try has succeeded.");
    }
}
catch (Exception e)
{
    Console.WriteLine("An exception has occurred");
    Console.WriteLine(e.Message);
}


// Try Catch Finally Practice
Console.WriteLine("Enter a number:");
string input = Console.ReadLine();
try
{
    int number = ParseStringToInt(input);
    Console.WriteLine("String successfully parsed, the result is " + number);
}
catch
{
    Console.WriteLine("An exception was thrown.");
}
finally
{
    Console.WriteLine("Finally block is being executed.");
}

Console.ReadKey();

int ParseStringToInt(string input)
{
    return int.Parse(input); // Could also use int.TryParse
}