namespace Bridge.Dishes.Cuisines;

public abstract class Cuisine
{
    public abstract int GetCuisineDiscountPercentage();
    
    public static Cuisine GetAmericanCuisine()
    {
        return new AmericanCuisine();
    }

    public static Cuisine GetJapaneseCuisine()
    {
        return new JapaneseCuisine();
    }

    public static Cuisine GetUkranianCuisine()
    {
        return new UkrainianCuisine();
    }
}