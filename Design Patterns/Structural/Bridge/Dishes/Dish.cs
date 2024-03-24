using Bridge.Dishes.Cuisines;
using Bridge.Dishes.DishTypes;

namespace Bridge.Dishes;

public interface IDish
{
    public float GetPrice();
    public Cuisine GetCuisine();
    public DishType GetDishType();
}

public class Dish : IDish
{
    private readonly Cuisine _cuisine;
    private readonly DishType _dishType;
    private readonly float _dishPrice;

    public Dish(Cuisine cuisine, DishType dishType, float dishPrice)
    {
        _cuisine = cuisine;
        _dishType = dishType;
        _dishPrice = dishPrice;
    }

    public float GetPrice()
    {
        var totalDiscountPercentage = _cuisine.GetCuisineDiscountPercentage() + _dishType.GetDishTypeDiscountPercentage();

        if (totalDiscountPercentage > 0)
        {
            return _dishPrice * (1 - totalDiscountPercentage * 0.01f);
        }

        return _dishPrice;
    }

    public Cuisine GetCuisine()
    {
        return _cuisine;
    }

    public DishType GetDishType()
    {
        return _dishType;
    }
}