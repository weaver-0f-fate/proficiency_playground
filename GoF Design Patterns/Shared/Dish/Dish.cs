using Shared.Enums;

namespace Shared.Dish;

public class Dish
{
    private string Name { get; }
    private List<string> Ingredients { get; }
    private float Price { get; }
    private Cuisine Cuisine { get; }

    public Dish(string name, float price, List<string> ingredients, Cuisine cuisine)
    {
        Name = name;
        Price = price;
        Ingredients = ingredients;
        Cuisine = cuisine;
    }

    public override string ToString()
    {
        return Name;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{Name} ({Cuisine} cuisine) is cooked from {string.Join(", ", Ingredients)}. Overall price is ${Price}");
    }
}