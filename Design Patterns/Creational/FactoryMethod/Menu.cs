using Shared.Dish;

namespace FactoryMethod;

public interface IMenu
{
    public Dish GetDishFromMenuItemNumber(int menuItemNumber);
}

public class Menu : IMenu
{
    private static readonly Dictionary<int, Dish> MenuItems = new()
    {
        { 1, Dishes.Pasta },
        { 2, Dishes.Pizza },
        { 3, Dishes.Burger },
        { 4, Dishes.FishSoup },
        { 5, Dishes.Steak }
    };

    public Dish GetDishFromMenuItemNumber(int menuItemNumber)
    {
        if (MenuItems.TryGetValue(menuItemNumber, out var dish))
        {
            return dish;
        }
        
        throw new KeyNotFoundException("Not found menu item, corresponding to menu item number.");
    }
}