Console.WriteLine("Hello, World!\n");

var rectangle1 = new Rectangle(10, 25);
Console.WriteLine("Width is " + rectangle1.Width);
rectangle1.Width = 15;
Console.WriteLine("Height is " + rectangle1.GetHeight());
//rectangle1.Width = 10; // this would error out

// Pause program and close
Console.WriteLine("\nPlease press enter to exit program.");
Console.ReadKey();

class Rectangle
{
    //const int NumberOfSides = 4; // const value to the class
    //readonly int NumberOfSidesReadonly; // readonly value

    public Rectangle(int width, int height)
    {
        //NumberOfSidesReadonly = 4;
        Width = GetLengthOrDefault(width, nameof(Width)); // you can still assign the value in the constructor
        _height = GetLengthOrDefault(height, nameof(_height));
    }

    // Creating a Width property with a getter and setter
    public int Width { get; private set; }

    //public int Width
    //{
    //    get
    //    {
    //        return _width;
    //    }
    //    set
    //    {
    //        if (value > 10)
    //        {
    //            _width = value;
    //        }
    //    }
    //}

    private int _height;

    public int GetHeight() => _height;

    public void SetHeight(int value)
    {
        if(value > 0)
        {
            _height = value;
        }
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

// Properties & getter / setter assignment
public class Order
{
    public string Item { get; }

    private DateTime _date;
    public DateTime Date
    {
        get
        {
            return _date;
        }
        set
        {
            if (value.Year == DateTime.Now.Year)
            {
                _date = value;
            }
        }
    }

    public Order(string item, DateTime date)
    {
        Item = item;
        Date = date;
    }
}


namespace Converter
{
    public class Converter
    {
        public string dnaToRna(string dna)
        {
            Console.WriteLine("Enter the DNA string you want converted to RNA here: ");
            string dna = Console.ReadLine();
            if (!IsNullOrWhiteSpace(dna))
            {
                string rna = dna.Replace('T', 'U');
                rna = dna;
                return rna;
                //         return string rna = dna.SubString(3) + "U";
            }
            else
            {
                Console.WriteLine("Please enter a valid dna value.");
            }
        }
    }
}