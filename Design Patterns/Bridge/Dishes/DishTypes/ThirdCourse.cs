namespace Bridge.Dishes.DishTypes;

public class ThirdCourse : DishType
{
    public override int GetDishTypeDiscountPercentage()
    {
        if (DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
        {
            // on Tuesday 10% discount on all Third Course dishes
            return 10;
        }

        return 0;
    }
}