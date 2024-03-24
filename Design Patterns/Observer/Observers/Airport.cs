namespace Observer.Observers;

public class Airport : AbstractStormObserver
{
    public override void WarnObserverAboutStorm(int stormLevel)
    {
        if (stormLevel > 5)
        {
            Console.WriteLine($"Storm is too strong. Flights are postponed.");
        }
    }
}