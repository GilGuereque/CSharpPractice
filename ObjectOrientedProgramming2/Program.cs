// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Instantiate a Person object
var person1 = new Person("Gil", 33, "Pizza");

// Call the Introduce method
person1.Introduce();


// Pause program
Console.ReadKey();

// Create Person class with an Introduce method
class Person
{
    public string Name;
    public int Age;
    public string FavoriteFood;

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

