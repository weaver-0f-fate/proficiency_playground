namespace Bridge.Dishes.DishTypes;

public class Dessert : DishType
{
    public override int GetDishTypeDiscountPercentage()
    {
        if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
        {
            // on Mondays 10% discount on all dessert dishes
            return 10;
        }

        return 0;
    }
}