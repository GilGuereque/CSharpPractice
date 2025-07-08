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

// HTTP request example
try
{
    var dataFromWeb = SendHttpRequest("www.address.com/get/someResource");
}
catch (HttpRequestException ex) when (ex.Message == "403")
{
    Console.WriteLine("It was forbidden to access the resource.");
    throw;
}
catch (HttpRequestException ex) when (ex.Message == "404")
{
    Console.WriteLine("The resource was not found.");
    throw;
}
catch (HttpRequestException ex) when (ex.Message.StartsWith("4")) // this would still be handled after the fact of the first two catch blocks due to the specifics of those two
{
    Console.WriteLine("There is some kind of client error.");
    throw;
}
catch (HttpRequestException ex) when (ex.Message == "500")
{
    Console.WriteLine("The server has experience an internal error.");
    throw;
}

// Custom Exceptions

throw new CustomException();

Console.ReadKey();

[Serializable]
public class CustomException : Exception
{
    public int StatusCode { get; }

    protected CustomException(
        SerializationInfo info,
        StreamingContext context) : base(info, context)
    {

    }
    public CustomException()
    {

    }

    public CustomException(string message, int statusCode) : base(message)
    {
        StatusCode = statusCode;
    }
    public CustomException(
        string message,
        int statusCode,
        Exception innerException) : base(message, innerException)
    {
        StatusCode = statusCode;
    }
    public CustomException(string message) : base(message)
    {

    }
    public CustomException(string message, Exception innerException)
        : base(message, innerException)
    {

    }
}
