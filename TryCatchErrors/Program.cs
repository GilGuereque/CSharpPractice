// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int userCheck = 1;

try
{
    if (userCheck == 1)
    {
        Console.WriteLine("The first try has succeeded.");
    }
}
catch (Exception e)
{
    Console.WriteLine(e);
}

Console.ReadKey();