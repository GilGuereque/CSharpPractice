//var invalidPersonObject = new Person("", -100);

//var emptyCollection = new List<int>();
//var firstElement = GetFirstElement(emptyCollection);
//var firstUsingLinq = emptyCollection.First();

//var numbers = new int[] { 1, 2, 3 };
//var fourth = numbers[3];

//bool has7 = CheckIfContains(7, numbers);

bool CheckIfContains(int value, int[] numbers)
{
    throw new NotImplementedException();
}

//try
//{
//    var result = GetFirstElement(new int[0]);
//}
//catch
//{

//}

RecursiveMethod(1); // calling the recursive method

try
{
    var result = IsFirstElementPositive(null);
}
catch(ArgumentNullException ex)
{

}

Console.ReadKey();

// Recursive method simple example
void RecursiveMethod(int counter)
{
    Console.WriteLine("I'm going to call myself. Counter is: " + counter);
    if (counter < 10)
    RecursiveMethod(counter + 1); // this will keep calling itself on and on ultimately ending in a stackoverflow exception
}

int GetFirstElement(IEnumerable<int> numbers)
{
    foreach(var number in numbers)
    {
        return number;
    }

    throw new Exception("The collection cannot be empty.");
}

bool IsFirstElementPositive(IEnumerable<int> numbers)
{
    try
    {
        var firstElement = GetFirstElement(numbers);
        return firstElement > 0;
    }
    catch(InvalidOperationException ex)
    {
        Console.WriteLine("The collection is empty!");
        return true;
    }
    catch(NullReferenceException ex)
    {
        Console.WriteLine("Sorry! The application experienced " +
            "an unexpected error.");
        //throw; //ex;
        throw new ArgumentNullException("The collection is null.", ex);
    }

}


class Person
{
    public string Name { get; }
    public int YearOfBirth { get; }

    public Person(string name, int yearOfBirth)
    {
        if(name is null)
        {
            throw new ArgumentNullException("The name cannot be null.");
        }
        if(name == string.Empty)
        {
            throw new ArgumentException("The name cannot be empty.");
        }
        if(yearOfBirth < 1900 || yearOfBirth > DateTime.Now.Year)
        {
            throw new ArgumentOutOfRangeException("The year of birth must be " +
                "between 1900 and the current year.");
        }

        Name = name;
        YearOfBirth = yearOfBirth;
    }
}