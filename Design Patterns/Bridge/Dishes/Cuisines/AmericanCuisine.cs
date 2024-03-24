namespace Bridge.Dishes.Cuisines;

public class AmericanCuisine : Cuisine
{
    public override int GetCuisineDiscountPercentage()
    {
        if (DateTime.Today.Day == 20)
        {
            // 20th 20% discount on all dishes of American Cuisine
            return 20;
        }

        return 0;
    }
}