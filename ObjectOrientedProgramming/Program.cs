// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! This is my introduction to OOP concepts and C# practice!");

// Weekly Assignment to create a simple flow asking a user for name, age and food inputs
// Then returning these in a greeting.
Console.WriteLine("Please enter your name, age, and favorite food.");
Console.WriteLine();

Console.WriteLine("What is your name? Enter here: ");
string name = Console.ReadLine();

Console.WriteLine("What is your age? Enter here: ");
string ageInput = Console.ReadLine();
// Convert ageInput to int (age)
int age;
Int32.TryParse(ageInput, out age);

Console.WriteLine("What is your favorite food? Enter here: ");
string favoriteFood = Console.ReadLine();

// Return the greeting
Console.WriteLine($"Thank you {name}! I also love {favoriteFood} by the way.");
Console.WriteLine($"You don't look your age at all! I am surprised you are: {age}");

Console.WriteLine();
Console.WriteLine();


// OOP Practice:
var internationalPizzaDay23 = new DateTime(2023, 2, 9);

Console.WriteLine("Year is " + internationalPizzaDay23.Year);
Console.WriteLine("Month is " + internationalPizzaDay23.Month);
Console.WriteLine("Day is " + internationalPizzaDay23.Day);
Console.WriteLine("Day of the week is " + internationalPizzaDay23.DayOfWeek);

var internationalPizzaDay24 = internationalPizzaDay23.AddYears(1);

Console.WriteLine("Year is " + internationalPizzaDay24.Year);
Console.WriteLine("Month is " + internationalPizzaDay24.Month);
Console.WriteLine("Day is " + internationalPizzaDay24.Day);
Console.WriteLine("Day of the week is " + internationalPizzaDay24.DayOfWeek);


// Pause program
Console.WriteLine();
Console.WriteLine("Press enter to exit program.");
Console.ReadKey();