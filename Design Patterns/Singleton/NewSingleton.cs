namespace Singleton;

public sealed class NewSingleton
{
    public int Number { get; } 
    
    private static int _instanceCount;
    private static readonly List<NewSingleton> Instances = new();
    private static readonly object LockObject = new();

    private NewSingleton()
    {
        var random = new Random();
        Number = random.Next(0, 100);
    }

    public static NewSingleton GetInstance()
    {
        if (_instanceCount < 10)
        {
            lock (LockObject)
            {
                if (_instanceCount < 10)
                {
                    var newInstance = new NewSingleton();
                    Instances.Add(newInstance);
                    _instanceCount++;
                    return newInstance;
                }
            }
        }

        // If already 10 instances created, return the first instance
        return Instances[0];
    }
}