using System.Runtime.Serialization;

Console.WriteLine("Enter a number: ");
string? input = Console.ReadLine();

try
{
    int number = int.Parse(input);
    var result = 10 / number;
    Console.WriteLine($"10 / {number} is " + result);
}
catch (DivideByZeroException ex)
{
    int.Parse("not an int");
    Console.WriteLine("Division by zero is not a valid operation. " + "Exception message: " + ex.Message);
}
catch (FormatException ex)
{
    Console.WriteLine(
        "Wrong format. Input string is not parsable to int. " +
        "Exception message: " + ex.Message);
}
