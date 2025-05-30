﻿using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Hello, World!");

// Ask the user for the program inputs needed
Console.WriteLine("Please enter your preferred name here: ");
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


// Bank Account Program
Console.WriteLine();
var bankAccount1 = new BankAccount("Gilberto Guereque", 350);

// Perform some deposits/withdrawals
bankAccount1.Deposit(3036);
bankAccount1.Withdraw(2000);
bankAccount1.Withdraw(2000); // This should now trigger "Insufficient funds"

// Display final balance
Console.WriteLine(bankAccount1.GetBalance());

// Medical Appointment program
Console.WriteLine();
var medicalAppointment = new MedicalAppointment(
    "John Smith", new DateTime(2023, 4, 3));

// Simple reschedule
medicalAppointment.Reschedule(new DateTime(2023, 4, 4));

// Creating medicalAppointments
var appointmentTwoWeeksFromNow = new MedicalAppointment("Bob Smith", 14);
var appointmentOneWeekFromNow = new MedicalAppointment("Margaret Smith");

// Print appointment


// Dog class
var balto = new Dog("Balto", "Siberian Husky", 18);
var nova = new Dog("Nova", "Australian Cattle Dog Mix", 27);
var ruby = new Dog("Ruby", "Pomeranian Mix", 4);
var hercules = new Dog("Hercules", "German Sherperd", 35);
//var zero = new Dog("Hercules", "German Sherperd", 0);

Console.WriteLine(balto.Describe());
Console.WriteLine(nova.Describe());
Console.WriteLine(ruby.Describe());
Console.WriteLine(hercules.Describe());

// Practicing const & readonly 
var rectangle1 = new Rectangle(5, 10);
//rectangle1.Width = 10; // this would error out

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

// Create a BankAccount class exercise
class BankAccount
{
    public string AccountHolder { get; private set; }
    public decimal Balance { get; private set; }

    public BankAccount(string accountHolder, decimal balance)
    {
        AccountHolder = accountHolder;
        Balance = balance;
    }

    public void Deposit(decimal addAmount)
    {
        if (addAmount <= 0)
        {
            Console.WriteLine("Sorry! This is an invalid deposit. The amount must be greater than $0.");
        }
        else
        {
            Balance += addAmount;
            Console.WriteLine($"Deposited ${addAmount}");
        }
    }

    public void Withdraw(decimal minusAmount)
    {
        if (minusAmount > Balance)
        {
            Console.WriteLine("Sorry, insufficient funds! Withdrawal has been canceled.");
        }
        else
        {
            Balance -= minusAmount;
            Console.WriteLine($"Withdrawn ${minusAmount}");
        }
    }

    public string GetBalance() => $"Current balance: ${Balance}";

}

class MedicalAppointmentPrinter
{
    public void Print(MedicalAppointment medicalAppointment)
    {
        Console.WriteLine(
            "Appointment will take place on " + medicalAppointment.GetDate());
    }
}

// Practicing Overloading constructors
class MedicalAppointment
{
    private string _patientName;
    private DateTime _date;
    
    public MedicalAppointment(string patientName, DateTime date)
    {
        _patientName = patientName;
        _date = date;
    }

    //public MedicalAppointment(string patientName) :
    //    this(patientName, 7);
    //{
    //}

    public MedicalAppointment(string patientName, int daysFromNow = 7)
    {
        _patientName = patientName;
        _date = DateTime.Now.AddDays(daysFromNow);
    }

    public DateTime GetDate() => _date;

    public void Reschedule(DateTime date)
    {
        _date = date;
        var printer = new MedicalAppointmentPrinter();
        printer.Print(this);
    }

    public void OverwriteMonthAndDay(int month, int day)
    {
        _date = new DateTime(_date.Year, month, day);
    }
}

// Practicing const & readonly 
//var rectangle1 = new Rectangle(5, 10);
//rectangle1.Width = 10; // this would error out

class Rectangle
{
    const int NumberOfSides = 4; // const value to the class
    readonly int NumberOfSidesReadonly; // readonly value
    public readonly int Width; // makes the fields readonly
    public readonly int Height;

    public Rectangle(int width, int height)
    {
        NumberOfSidesReadonly = 4;
        Width = GetLengthOrDefault(width, nameof(Width)); // you can still assign the value in the constructor
        Height = GetLengthOrDefault(height, nameof(Height));
    }

    private int GetLengthOrDefault(int length, string name)
    {
        const int defaultValueIfNonPositive = 1; // make this a const value since it won't ever change
        if (length <= 0)
        {
            Console.WriteLine($"{name} must be a postive number.");
            return defaultValueIfNonPositive;
        }
        return length;
    }
}

    // Dog Class Assignment
    class Dog
{
    public string Name;
    public string Breed;
    public int Weight;



    public Dog(string name, string breed, int weight)
    {
        if (weight <= 0)
        {
            Console.WriteLine("Weight must be a positive number.");
        }
        else
        {
            Name = name;
            Breed = breed;
            Weight = weight;
        }
    }

    public Dog(string name, int weight)
        : this(name, "mixed-breed", weight)
    {
        //Name = name;
        //Weight = weight;
    }

    public string Describe()
    {
        if (Weight < 5)
        {
            return $"For a dog named {Name}, it's a {Breed}, and it weighs {Weight} kilograms, so it's a tiny dog.";
        }
        else if (Weight < 30)
        {
            return $"For a dog named {Name}, it's a {Breed}, and it weighs {Weight} kilograms, so it's a medium dog.";
        }
        else
        {
            return $"For a dog named {Name}, it's a {Breed}, and it weighs {Weight} kilograms, so it's a large dog.";
        }
    }
}
