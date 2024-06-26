﻿// // Applying logic 
// Console.WriteLine("a" == "a");
// Console.WriteLine("a" == "A");
// Console.WriteLine(1 == 2);

// // string myValue = "a";
// // Console.WriteLine(myValue == "a");

// // Applying Trim, ToUpper, ToLower
// string value1 = " a";
// string value2 = "A ";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// // Using inequality operator
// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);

// string myValue = "a";
// Console.WriteLine(myValue != "a");

// // comparison operators
// Console.WriteLine(1 > 2);
// Console.WriteLine(1 < 2);
// Console.WriteLine(1 >= 1);
// Console.WriteLine(1 <= 1);

// // // Methods that return a boolean
// // string pangram = "The quick brown fox jumps over the lazy dog.";
// // Console.WriteLine(pangram.Contains("fox"));
// // Console.WriteLine(pangram.Contains("cow"));

// // // these two lines should create the same output
// // Console.WriteLine(pangram.Contains("fox") == false);
// // Console.WriteLine(!pangram.Contains("fox"));

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(!pangram.Contains("fox"));
// Console.WriteLine(!pangram.Contains("cow"));

// CONDITIONAL OPERATORS
// int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;
// This is saying the discount will either be
// 100 if the saleAmount is greater than 1000 else 50
// Console.WriteLine($"Discount: {discount}");

// // You can also do it inline
// int saleAmount = 1001;
// Console.WriteLine($"Discount: {saleAmount}/t");


// // coin flipper possible solution:
// Random coin = new Random();
// int flip = coin.Next(0, 2);
// Console.WriteLine((flip == 0) ? "heads": "tails");

// // another possible coin flip solution
// Random coin = new Random();
// Console.WriteLine((coin.Next(0, 2) == 0) ? "heads": "tails");

// my solution
string permission = "Admin|Manager";
int level = 55;

if ( permission.Contains("Admin") && level > 55 )
{
    Console.WriteLine("Welcome, Super Admin user.");
} 
else if ( permission.Contains("Manager") && level < 20 )
{
    Console.WriteLine("You do not have sufficient privileges.");
}
else if ( permission.Contains("Admin") && level <= 55 )
{
    Console.WriteLine("Welcome, Admin user.");
}
else if ( !permission.Contains("Manager") && !permission.Contains("Admin") )
{
    Console.WriteLine("You do not have sufficient privileges.");
}

// solution answer (possible solution):
string permission = "Admin|Manager";
int level = 53;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}