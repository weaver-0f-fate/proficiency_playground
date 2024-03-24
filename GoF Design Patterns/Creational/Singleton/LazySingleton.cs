namespace Singleton;

/// <summary>
/// Singleton using Lazy functionality of C# language.
/// objects are not initialized until they are actually used.
/// handling multi-thread calls out of the box.
/// </summary>
public class LazySingleton
{
    public int Number { get; }
    
    private static readonly Lazy<LazySingleton>[] LazyInstances = new Lazy<LazySingleton>[10];

    private LazySingleton()
    {
        var random = new Random();
        Number = random.Next(0, 100);
    }

    public static LazySingleton GetInstance(int index)
    {
        if (index is >= 0 and < 10)
        {
            return LazyInstances[index].Value;
        }

        throw new ArgumentOutOfRangeException(nameof(index), "Index must be between 0 and 9.");
    }

    static LazySingleton()
    {
        for (var i = 0; i < 10; i++)
        {
            LazyInstances[i] = new Lazy<LazySingleton>(() => new LazySingleton());
        }
    }
}