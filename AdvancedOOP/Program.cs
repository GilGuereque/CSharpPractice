////Polymorphism & Inheritance
//var pizza = new Pizza();
//pizza.AddIngredient(new Cheddar());
//pizza.AddIngredient(new Mozzarella());
//pizza.AddIngredient(new TomatoSauce());

//Console.WriteLine(pizza.Describe());

//Console.WriteLine("Variable of type Cheddar");
//Cheddar cheddar = new Cheddar(); //explicity typed derived class for more clarity
//cheddar.PublicField = 20;
//Console.WriteLine(cheddar.Name);

//Console.WriteLine("Variable of type Ingredient");
//Ingredient ingredient = new Cheddar(); //this variable is of type Ingredient, but stores object of type Cheddar. This works because Cheddar is an ingredient. However Ingredient class does not have a Name method
//Console.WriteLine(ingredient.Name);



//Console.WriteLine("value in ingredient: " + ingredient.PublicField);
//Console.WriteLine("value in cheddar: " + cheddar.PublicField);
//Console.WriteLine(new Tiger().MakeTigerNoise());
//Console.WriteLine(cheddar.PublicMethod());
//Console.WriteLine(cheddar.ProtectedMethod());
//Console.WriteLine(cheddar.PrivateMethod());

//var ingredients = new List<Ingredient>
//{
//    new Cheddar(),
//    new Mozzarella(),
//    new TomatoSauce()
//};

//foreach(Ingredient ingredient in ingredients)
//{
//    Console.WriteLine(ingredient.Name);
//}

var ingredient = new Ingredient(1);

var cheddar = new Cheddar(2, 12);
Console.WriteLine(cheddar);

//var cheddar = new Cheddar();
//Console.WriteLine(cheddar);


Console.ReadKey();

public class Pizza
{
    private List<Ingredient> _ingredients = new List<Ingredient>();

    public void AddIngredient(Ingredient ingredient) =>
        _ingredients.Add(ingredient);

    public string Describe() =>
        $"This is a pizza with {string.Join(", ", _ingredients)}";
}

public class Ingredient
{
    public Ingredient(int priceIfExtraTopping)
    {
        Console.WriteLine(
            "Constructor from the Ingredient class");
        PriceIfExtraTopping = priceIfExtraTopping;
    }

    public int PriceIfExtraTopping { get;  }

    public override string Tostring() => Name;
    
    public virtual string Name { get; } = "Some ingredient";
    
    public int PublicField;
    
    public string PublicMethod() =>
        "This method is PUBLIC in the Ingredient class.";

    protected string ProtectedMethod() =>
    "This method is PROTECTED in the Ingredient class.";

    private string PrivateMethod() =>
        "This method is PRIVATE in the Ingredients class.";
}

public class Cheese : Ingredient
{
    public Cheese(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
        
    }
}

public class Cheddar : Cheese
{
    public Cheddar(int priceIfExtraTopping, int agedForMonths) 
        : base(priceIfExtraTopping)
    {
        AgedForMonths = agedForMonths;
        Console.WriteLine(
            "Constructor from the Cheddar class");
    }

    public override string Name =>
        $"{base.Name}, more specifically, " +
        $"a Cheddar cheese aged for {AgedForMonths} months";

    public int AgedForMonths { get; }

    public void UseMethodsFromBaseClass()
    {
        Console.WriteLine(PublicMethod());
        Console.WriteLine(ProtectedMethod());
        //Console.WriteLine(PrivateMethod());
    }
}

public class TomatoSauce : Ingredient
{
    public TomatoSauce(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
        
    }

    public override string Name => "Tomato Sauce";
    public int TomatosIn100Grams { get; }
}

public class Mozzarella : Cheese
{
    public Mozzarella(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
        
    }

    public override string Name => "Mozzarella";
    public bool IsLight { get; }
}

public class Animal
{
    public virtual string MakeNoise() => "Roar";
}

public class Tiger : Animal
{
    public string MakeTigerNoise() =>
        MakeNoise() + "!!!";
}

public class HousePet : Animal
{
    public override void MakeSound() =>
        Console.WriteLine("<noises of happiness when human comes home>");
}

public class Feline : Animal
{
    public override void MakeSound() =>
        Console.WriteLine("purr purr");
}

public class DomesticCat : Feline
{
    //How could C# engine know which MakeSound method is being called? This is the diamond problem
}