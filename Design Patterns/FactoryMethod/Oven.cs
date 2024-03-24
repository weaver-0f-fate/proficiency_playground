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
        // Фактори метод, который определяет какое именно блюдо нужно создать отдан классу меню.
        var dish = _menu.GetDishFromMenuItemNumber(menuItemNumber);
        //логика приготовления опущена
        return dish;
    }
}