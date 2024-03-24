namespace Observer.Observers;

public interface IStormObserver
{
    public void WarnObserverAboutStorm(int stormLevel);
}

public abstract class AbstractStormObserver : IStormObserver
{
    public static IEnumerable<IStormObserver> GetDefaultStormObservers()
    {
        return new List<IStormObserver>
        {
            new Airport(),
            new School(),
            new RoadService()
        };
    }
    public abstract void WarnObserverAboutStorm(int stormLevel);
}