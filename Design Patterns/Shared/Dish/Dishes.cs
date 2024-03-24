using Shared.Enums;

namespace Shared.Dish;

public static class Dishes
{
    public static Dish Pasta = new("Pasta", 2.50f, new List<string> { "Pasta", "Souse", "Vegetables" }, Cuisine.Ukrainian);
    public static Dish Pizza = new("Pizza", 5.00f, new List<string> { "Cheese", "Souse", "Vegetables", "Spices" }, Cuisine.American);
    public static Dish Burger = new("Burger", 2.50f, new List<string> { "Meat", "Cheese", "Onion", "Ketchup" }, Cuisine.American);
    public static Dish FishSoup = new("FishSoup", 2.00f, new List<string> { "Trout", "Potato", "Spices", "Onion" }, Cuisine.Japanese);
    public static Dish Steak = new("Steak", 5.00f, new List<string> { "Beef", "Souse", "Potato", "Paprika" }, Cuisine.American);
    public static Dish Borsch = new("Borsch", 4.00f, new List<string>{"Potato", "Beet", "Pork" }, Cuisine.Ukrainian);
}