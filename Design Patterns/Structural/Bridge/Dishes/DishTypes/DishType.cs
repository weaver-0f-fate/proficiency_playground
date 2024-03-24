namespace Bridge.Dishes.DishTypes;

public abstract class DishType
{
    public abstract int GetDishTypeDiscountPercentage();
    
    public static DishType GetDessertType()
    {
        return new Dessert();
    }
    
    public static DishType GetFirstCourseType()
    {
        return new FirstCourse();
    }

    public static DishType GetSecondCourseType()
    {
        return new SecondCourse();
    }

    public static DishType GetThirdCourseType()
    {
        return new ThirdCourse();
    }
}