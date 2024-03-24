using Bridge.Dishes.Cuisines;
using Bridge.Dishes.DishTypes;

namespace Bridge.Dishes;

public interface IDishFactory
{
    public IEnumerable<IDish> GetDishes();
    public IEnumerable<IDish> GetDesserts();
    public IEnumerable<IDish> GetAmericanDishes();
}

public class DishFactory : IDishFactory
{
    private readonly IEnumerable<IDish> _dishes = new List<IDish>()
    {
        new Dish(Cuisine.GetAmericanCuisine(), DishType.GetFirstCourseType(), 2.20f),
        new Dish(Cuisine.GetJapaneseCuisine(), DishType.GetSecondCourseType(), 3.30f),
        new Dish(Cuisine.GetJapaneseCuisine(), DishType.GetDessertType(), 4.10f),
        new Dish(Cuisine.GetUkranianCuisine(), DishType.GetFirstCourseType(), 2.50f),
        new Dish(Cuisine.GetUkranianCuisine(), DishType.GetSecondCourseType(), 4.00f),
    };

    public IEnumerable<IDish> GetDishes()
    {
        return _dishes;
    }

    public IEnumerable<IDish> GetDesserts()
    {
        return _dishes.Where(dish => dish.GetDishType() is Dessert);
    }

    public IEnumerable<IDish> GetAmericanDishes()
    {
        return _dishes.Where(dish => dish.GetCuisine() is AmericanCuisine);
    }
}