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


// Bank Account Program
Console.WriteLine();
var bankAccount1 = new BankAccount("Gilberto Guereque", 350);

// Perform some deposits/withdrawals
bankAccount1.Deposit(3036);
bankAccount1.Withdraw(2000);
bankAccount1.Withdraw(2000); // This should now trigger "Insufficient funds"

// Display final balance
bankAccount1.GetBalance();

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

    public void GetBalance()
    {
        Console.WriteLine($"Current balance: ${Balance}");
    }
}
