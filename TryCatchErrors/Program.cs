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

Console.ReadKey();