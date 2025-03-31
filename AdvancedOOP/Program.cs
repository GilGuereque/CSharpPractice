//Polymorphism & Inheritance

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
    public string Name { get; }
    public int AgedForMonths { get; }
    public int TomatosIn100Grams { get; }
    public bool isLight {  get; }

    public class Cheddar
{
    public string Name => "Cheddar cheese";
    public int AgedForMonths { get; }
}

public class TomatoSauce
{
    public string Name => "Tomato Sauce";
    public int TomatosIn100Grams { get; }
}