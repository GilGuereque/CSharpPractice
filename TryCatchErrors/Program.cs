// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//int userCheck = 2;

//try
//{
//    if (userCheck == 1)
//    {
//        Console.WriteLine("The first try has succeeded.");
//    }
//}
//catch (Exception e)
//{
//    Console.WriteLine("An exception has occurred");
//    Console.WriteLine(e.Message);
//}


// Try Catch Finally Practice
Console.WriteLine("Enter a number:");
string input = Console.ReadLine();
try
{
    int number = ParseStringToInt(input);
    var result = 10 / number;
    Console.WriteLine(
        $"10 / {number} is " + result);
}
catch(FormatException ex)
{
    Console.WriteLine(
        "Wrong format. Input string is not parsable to int. " +
        "Exception message: " + ex.Message);
}
catch(DivideByZeroException ex)
{
    Console.WriteLine("Division by zero is an invalid operation. " +
        "Exception message: " + ex.Message);
}
catch(Exception ex)
{
    Console.WriteLine("Unexpected error occurred. " +
        "Exception message: " + ex.Message);
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
