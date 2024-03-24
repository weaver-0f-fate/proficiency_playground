namespace Observer.Observers;

public class School : AbstractStormObserver
{
    public override void WarnObserverAboutStorm(int stormLevel)
    {
        if (stormLevel >= 4)
        {
            Console.WriteLine("Storm level is too high, lessons must be cancelled.");
        }
    }
}