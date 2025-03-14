Console.WriteLine("Hello, World!");
Console.WriteLine(Rectangle.DescribeGenerally());

// Calculator Example ( this method works fine,
// But it may seem odd to have to create an object of the class
// in order to perform the calculations - we could create another object
// and it would never matter which object we use to perform those calculations
// because the parameters have no values assigned. It could be any value
//var calculator = new Calculator();
Console.WriteLine($"1 + 2 is {Calculator.Add(1, 2)}");
Console.WriteLine($"1 + 2 is {Calculator.Subtract(1, 2)}");
Console.WriteLine($"1 + 2 is {Calculator.Multiply(1, 2)}");

static class Calculator
{
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
    public static int Multiply(int a, int b) => a * b;
    public static int Divide(int a, int b) => a / b;
}

class Rectangle
{
    public int Width;
    public int Height;
    const int NumberOfSides = 4;

    public Rectangle(int width, int height)
    {
        Width = Width;
        Height = Height;
    }

    public static string DescribeGenerally() =>
        $"A plane figure with four straight sides and four right angles.";
}