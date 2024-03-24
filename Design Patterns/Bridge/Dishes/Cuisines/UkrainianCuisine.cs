namespace Bridge.Dishes.Cuisines;

public class UkrainianCuisine : Cuisine
{
    public override int GetCuisineDiscountPercentage()
    {
        if (DateTime.Today.Day == 10)
        {
            // 10th 20% discount on all dishes of Ukrainian Cuisine
            return 20;
        }

        return 0;
    }
}