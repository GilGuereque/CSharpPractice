//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World! This is my introduction to OOP concepts and C# practice!");

//// Weekly Assignment to create a simple flow asking a user for name, age and food inputs
//// Then returning these in a greeting.
//Console.WriteLine("Please enter your name, age, and favorite food.");
//Console.WriteLine();

//Console.WriteLine("What is your name? Enter here: ");
//string name = Console.ReadLine();

//Console.WriteLine("What is your age? Enter here: ");
//string ageInput = Console.ReadLine();
//// Convert ageInput to int (age)
//int age;
//Int32.TryParse(ageInput, out age);

//Console.WriteLine("What is your favorite food? Enter here: ");
//string favoriteFood = Console.ReadLine();

//// Return the greeting
//Console.WriteLine($"Thank you {name}! I also love {favoriteFood} by the way. You loveee to copy me must be!");
//Console.WriteLine();
//Console.WriteLine($"But wow! I am surprised you are {age} now... you really are getting old doofalooo");

//Console.WriteLine();
//Console.WriteLine();


//// OOP Practice:
//var internationalPizzaDay23 = new DateTime(2023, 2, 9);

//Console.WriteLine("Year is " + internationalPizzaDay23.Year);
//Console.WriteLine("Month is " + internationalPizzaDay23.Month);
//Console.WriteLine("Day is " + internationalPizzaDay23.Day);
//Console.WriteLine("Day of the week is " + internationalPizzaDay23.DayOfWeek);

//var internationalPizzaDay24 = internationalPizzaDay23.AddYears(1);

//Console.WriteLine("Year is " + internationalPizzaDay24.Year);
//Console.WriteLine("Month is " + internationalPizzaDay24.Month);
//Console.WriteLine("Day is " + internationalPizzaDay24.Day);
//Console.WriteLine("Day of the week is " + internationalPizzaDay24.DayOfWeek);
//Console.WriteLine();

// Creating our first class
using System.Security.Cryptography.X509Certificates;

var rectangle1 = new Rectangle(5, 10);
//var calculator = new ShapesMeasurementsCalculator(rectangle1);

Console.WriteLine("Width is " + rectangle1.Width);
Console.WriteLine("Height is " + rectangle1.Height);
//Console.WriteLine("Area is " + rectangle1.CalculateArea());
//Console.WriteLine("Circumference is " + rectangle1.CalculateCircumference());

var rectangle2 = new Rectangle(10, 20);

//Console.WriteLine("Width is " + rectangle2.Width);
//Console.WriteLine("Height is " + rectangle2.Height);
//Console.WriteLine("Area is " + rectangle2.CalculateArea());
//Console.WriteLine("Circumference is " + rectangle2.CalculateCircumference());

Console.WriteLine();

// Parse the date string into a DateTime object
string startDateString = "11/01/2025";
DateTime startDate = DateTime.ParseExact(startDateString, "MM/dd/yyyy", null);

// Create the HotelBooking object
var hotelBooking1 = new HotelBooking("Gilberto Guereque", startDate, 3);

// Display the booking details
Console.WriteLine($"Hello {hotelBooking1.GuestName}, your check-in date is: {hotelBooking1.StartDate.ToString("MM/dd/yyyy")}, for {hotelBooking1.EndDate.Subtract(hotelBooking1.StartDate).Days} days. Your check-out date will be: {hotelBooking1.EndDate.ToString("MM/dd/yyyy")}.");

//Console.ReadKey();

//// Testing await method
//Console.Write("Hello ");
//await Task.Delay(5000);
//Console.WriteLine("World!");

var medicalAppointment = new MedicalAppointment(
    "John Smith", new DateTime(2023, 4, 3));

// overwrite month and day
medicalAppointment.OverwriteMonthAndDay(5, 1);

// add a given number of months and days
medicalAppointment.MoveByMonthsAndDays(1, 2);

// Pause program
Console.WriteLine();
Console.WriteLine("Press enter to exit program.");
Console.ReadKey();

class Rectangle
{
    public int Width;
    public int Height;

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

}

//class ShapesMeasurementsCalculator
//{
//    public ShapesMeasurementsCalculator(Rectangle rectangle)
//    {
            
//    }
//    public int CalculateCircumference(rectangle)
//    {
//        return 2 * rectangle.Width + 2 * rectangle.Height;
//    }

//    public int CalculateArea(Rectangle rectangle)
//    {
//        return rectangle.Width * rectangle.Height;
//    }
//}

class MedicalAppointment
{
    private string _patientName;
    private DateTime _date;

    public MedicalAppointment(string patientName, DateTime date)
    {
        _patientName = patientName;
        _date = date;
    }

    public void Reschedule(DateTime date)
    {
        _date = date;
    }

    public void OverwriteMonthAndDay(int month, int day)
    {
        _date = new DateTime(_date.Year, month, day);
    }

    public void MoveByMonthsAndDays(int monthsToAdd, int daysToAdd)
    {
        _date = new DateTime(
            _date.Year,
            _date.Month + monthsToAdd,
            _date.Day + daysToAdd);
    }
}

class ListElementsAdder
{
    public void Add(int itemToBeAdded, List<int> list)
    {
        //public list.Count;
    }
}


class HotelBooking
{
    public string GuestName;
    public DateTime StartDate;
    public DateTime EndDate;

    public HotelBooking(string guestName, DateTime startDate, int lengthOfStayInDays)
    {
        GuestName = guestName;
        StartDate = startDate;
        //EndDate = StartDate + lengthOfStayInDays;
        EndDate = StartDate.AddDays(lengthOfStayInDays);
    }
}
// for example we could have to 2 instances of rectangles with different measurements


//var square = new Square(10);
//Console.WriteLine(
//    "Square side is: " + square.Side);

public class Square
{
    int Side = 5;
    public Square(int side)
    {
        Side = side;
    }
}


// Coding exercise:
//using System;

//namespace Coding.Exercise
    class Triangle
    {
        private int _base;
        private int _height;

        public Triangle(int @base, int height)
        {
            _base = @base;
            _height = height;

        }

        public int CalculateArea()
        {
            return ((_base * _height) / 2);
        }

        public string AsString()
        {
            return $"Base is {_base}, height is {_height}";
        }
    }

