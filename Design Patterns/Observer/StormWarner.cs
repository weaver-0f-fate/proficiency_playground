using Observer.Observers;

namespace Observer;

public interface IStormWarner
{
    public void GenerateStorm(int stormLevel);
    public void AddObserver(IStormObserver observer);
    public void AddObservers(IEnumerable<IStormObserver> observers);
    public void RemoveObserver(IStormObserver observer);
}

public class StormWarner : IStormWarner
{
    private readonly List<IStormObserver> _observers;
    
    public StormWarner()
    {
        _observers = new List<IStormObserver>();
    }

    public void GenerateStorm(int stormLevel)
    {
        Console.WriteLine($"Storm of level {stormLevel} was generated.");
        WarnObservers(stormLevel);
    }
    
    private void WarnObservers(int stormLevel)
    {
        foreach (var observer in _observers)
        {
            observer.WarnObserverAboutStorm(stormLevel);
        }
    }

    public void AddObserver(IStormObserver observer)
    {
        _observers.Add(observer);
    }

    public void AddObservers(IEnumerable<IStormObserver> observers)
    {
        _observers.AddRange(observers);
    }

    public void RemoveObserver(IStormObserver observer)
    {
        _observers.Remove(observer);
    }
}