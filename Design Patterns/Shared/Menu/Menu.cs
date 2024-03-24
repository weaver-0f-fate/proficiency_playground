using Shared.Dish;

namespace Shared.Menu;

public interface IMenu
{
    public IEnumerable<Dish.Dish> GetAmericanComplexLunchDishes();
    public IEnumerable<Dish.Dish> GetJapaneseComplexLunchDishes();
    public IEnumerable<Dish.Dish> GetUkrainianComplexLunchDishes();
}

public class Menu : IMenu
{
    private static readonly MenuItem AmericanComplexLunch = new (1, new []{Dishes.Burger, Dishes.Pizza});
    private static readonly MenuItem JapaneseComplexLunch = new (2, new []{Dishes.FishSoup});
    private static readonly MenuItem UkrainianComplexLunch = new (3, new []{Dishes.Pasta, Dishes.Borsch });
    
    public IEnumerable<Dish.Dish> GetAmericanComplexLunchDishes()
    {
        return AmericanComplexLunch.Dishes;
    }

    public IEnumerable<Dish.Dish> GetJapaneseComplexLunchDishes()
    {
        return JapaneseComplexLunch.Dishes;
    }

    public IEnumerable<Dish.Dish> GetUkrainianComplexLunchDishes()
    {
        return UkrainianComplexLunch.Dishes;
    }
}