// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Ask the user for the program inputs needed
Console.WriteLine("Please enter your preffered name here: ");
string person = Console.ReadLine();

Console.WriteLine();
Console.WriteLine("Please enter your age here: ");
int age = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Lastly, please enter your favorite food here: ");
string favoriteFood = Console.ReadLine();


// Instantiate a Person object
var person1 = new Person(person, age, favoriteFood);

// Call the Introduce method
Console.WriteLine();
person1.Introduce();


// Pause program
Console.WriteLine();
Console.WriteLine("Press enter to end program.");
Console.ReadKey();

// Create Person class with an Introduce method
class Person
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    public string FavoriteFood { get; private set; }

    public Person(string name, int age, string favoriteFood)
    {
        Name = name;
        Age = age;
        FavoriteFood = favoriteFood;
    }

    public void Introduce() // prints a greeting
    {
        Console.WriteLine(
            $"Hi, my name is {Name}, I am {Age} years old, and I love eating {FavoriteFood}!");
    }
}

