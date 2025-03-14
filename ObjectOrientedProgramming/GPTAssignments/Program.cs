using System.Numerics;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello, World!");
Console.WriteLine("This program lets you know if a number is even or odd.");

bool userContinue = true;

while (userContinue)
{
    Console.WriteLine("\nPlease enter a number, and we will tell you if its even or odd. Enter here: ");
    string userInput = Console.ReadLine().Trim();
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
    string userChoice = Console.ReadLine().Trim();
    if (userChoice == "0")
    {
        userContinue = false;
    }
}

string ReverseString(string input)
{
    // Convert the input string to an array of characters.
    char[] charArray = input.ToCharArray();

    // Reverse the order of the elements in the array
    Array.Reverse(charArray);

    // Create a new string from the reversed array and return it.
    return new string(charArray);
}

// object initializers
var person = new Person
{
    Name = "John",
    YearOfBirth = 1981
};

person.Name = "Henry";



class Person
{
    public string Name { get; set; }
    public int YearOfBirth { get; init; }

    public Person(string name)
    {
        Name = Name;
    }

    //public Person(string name, int yearOfBirth)
    //{
    //    Name = name;
    //    YearOfBirth = yearOfBirth;
    //}
}

// Computed properties exercise
using System;

namespace Coding.Exercise
{
    public class DailyAccountState
    {
        public int InitialState { get; }

        public int SumOfOperations { get; }

        public DailyAccountState(
            int initialState,
            int sumOfOperations)
        {
            InitialState = initialState;
            SumOfOperations = sumOfOperations;
        }

        public int EndOfDayState => InitialState + SumOfOperations;

        public string Report => $"Day: {DateTime.Now.Day}, month: {DateTime.Now.Month}, year: {DateTime.Now.Year}, initial state: {InitialState}, end of day state: {EndOfDayState}";
    }
}
