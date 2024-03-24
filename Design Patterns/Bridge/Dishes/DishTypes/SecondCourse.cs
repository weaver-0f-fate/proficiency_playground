namespace Bridge.Dishes.DishTypes;

public class SecondCourse : DishType
{
    public override int GetDishTypeDiscountPercentage()
    {
        if (DateTime.Today.DayOfWeek == DayOfWeek.Wednesday)
        {
            // on Wednesday 10% discount on all second Course dishes
            return 10;
        }

        return 0;
    }
}