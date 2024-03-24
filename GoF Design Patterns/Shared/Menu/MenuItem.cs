namespace Shared.Menu;

public class MenuItem
{
    public int Number { get; }
    public IEnumerable<Dish.Dish> Dishes { get; set; }

    public MenuItem(int number, IEnumerable<Dish.Dish> dishes)
    {
        Number = number;
        Dishes = dishes;
    }
}