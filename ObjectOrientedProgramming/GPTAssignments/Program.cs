using System.Numerics;

Console.WriteLine("Hello, World!");
Console.WriteLine("This program lets you know if a number is even or odd.");

bool userContinue = true;

while (userContinue)
{
    Console.WriteLine("\nPlease enter a number, and we will tell you if its even or odd. Enter here: ");
    string userInput = Console.ReadLine();
    BigInteger number;

    // Parse number and validate its a numerical value
    if (!BigInteger.TryParse(userInput, out number))
    {
        Console.WriteLine("You must enter a numerical value. Please try again.");
            continue; // Skip to the next iteration if parsing fails
    }

    if (number % 2 == 0)
    {
        Console.WriteLine("Even");
    }
    else
    {
        Console.WriteLine("Odd");
    }
    Console.WriteLine("\nPress 0 to exit program, otherwise Enter to continue running it. Enter here: ");
    string userChoice = Console.ReadLine();
    if (userChoice == "0")
    {
        userContinue = false;
    }
}
