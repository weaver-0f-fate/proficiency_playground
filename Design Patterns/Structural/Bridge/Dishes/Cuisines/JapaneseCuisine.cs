namespace Bridge.Dishes.Cuisines;

public class JapaneseCuisine : Cuisine
{
    public override int GetCuisineDiscountPercentage()
    {
        if (DateTime.Today.Day == 15)
        {
            // 15th 20% discount on all dishes of Japanese Cuisine
            return 20;
        }

        return 0;
    }
}