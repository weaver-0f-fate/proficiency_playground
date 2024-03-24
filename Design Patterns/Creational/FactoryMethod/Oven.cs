using Shared.Dish;

namespace FactoryMethod;

public interface IOven
{
    public Dish Cook(int menuItemNumber);
}

public class Oven : IOven
{
    private readonly IMenu _menu;

    public Oven(IMenu menu)
    {
        _menu = menu;
    }
    
    public Dish Cook(int menuItemNumber)
    {
        var dish = _menu.GetDishFromMenuItemNumber(menuItemNumber);
        return dish;
    }
}