namespace Bridge.Dishes.DishTypes;

public class FirstCourse : DishType
{
    public override int GetDishTypeDiscountPercentage()
    {
        if (DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
        {
            // on Thursday 10% discount on all First Course dishes
            return 10;
        }

        return 0;
    }   
}