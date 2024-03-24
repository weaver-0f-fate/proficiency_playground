using Bridge.Dishes;

namespace Bridge;

public interface IOrder
{
    public float GetTotalPrice();
}

public class Order : IOrder
{
    private readonly IEnumerable<IDish> _orderedDishes;
    
    public Order(IEnumerable<IDish> orderedDishes)
    {
        _orderedDishes = orderedDishes;
    }

    public float GetTotalPrice()
    {
        return _orderedDishes.Sum(orderedDish => orderedDish.GetPrice());
    }
}