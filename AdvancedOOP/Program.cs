﻿//Polymorphism & Inheritance
var pizza = new Pizza();
pizza.AddIngredient(new Cheddar());
pizza.AddIngredient(new Mozzarella());
pizza.AddIngredient(new TomatoSauce());

Console.WriteLine(pizza.Describe());

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

}

public class Cheddar : Ingredient
{
    public string Name => "Cheddar cheese";
    public int AgedForMonths { get; }
}

public class TomatoSauce : Ingredient
{
    public string Name => "Tomato Sauce";
    public int TomatosIn100Grams { get; }
}

public class Mozzarella : Ingredient
{
    public string Name => "Mozzarella";
    public bool IsLight { get; }
}