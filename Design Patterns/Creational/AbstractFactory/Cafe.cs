using Shared.Dish;

namespace AbstractFactory;

public interface ICafe
{
    public void OrderAmericanLunch();
    public void OrderJapaneseLunch();
    public void OrderUkrainianLunch();
}

public class Cafe : ICafe
{
    private readonly IOven _oven;
    
    public Cafe(IOven oven)
    {
        _oven = oven;
    }

    public void OrderAmericanLunch()
    {
        var dishes = _oven.CookAmericanComplexLunch();
        CompleteOrder(dishes);
    }

    public void OrderJapaneseLunch()
    {
        var dishes = _oven.CookJapaneseComplexLunch();
        CompleteOrder(dishes);
    }

    public void OrderUkrainianLunch()
    {
        var dishes = _oven.CookUkrainianComplexLunch();
        CompleteOrder(dishes);
    }

    private void CompleteOrder(IEnumerable<Dish> dishes)
    {
        Console.WriteLine($"Order from {string.Join(", ", dishes)} is ready!");
    }
}