using Shared.Dish;
using Shared.Menu;

namespace AbstractFactory;

public interface IOven
{
    public IEnumerable<Dish> CookAmericanComplexLunch();
    public IEnumerable<Dish> CookJapaneseComplexLunch();
    public IEnumerable<Dish> CookUkrainianComplexLunch();
}

public class Oven : IOven
{
    private readonly IMenu _menu;
    
    public Oven(IMenu menu)
    {
        _menu = menu;
    }

    public IEnumerable<Dish> CookAmericanComplexLunch()
    {
        var dishes = _menu.GetAmericanComplexLunchDishes();
        //cooking dishes;
        return dishes;
    }

    public IEnumerable<Dish> CookJapaneseComplexLunch()
    {
        var dishes = _menu.GetJapaneseComplexLunchDishes();
        //cooking dishes;
        return dishes;
    }

    public IEnumerable<Dish> CookUkrainianComplexLunch()
    {
        var dishes = _menu.GetUkrainianComplexLunchDishes();
        //cooking dishes;
        return dishes;
    }
}