namespace Observer.Observers;

public class RoadService : AbstractStormObserver
{
    public override void WarnObserverAboutStorm(int stormLevel)
    {
        switch (stormLevel)
        {
            case >= 1 and < 5:
                Console.WriteLine("Casual storm level, send out 2 cleaning machines.");
                break;
            case >= 5 and < 8:
                Console.WriteLine("Middle storm level, send out 5 cleaning machines.");
                break;
            default:
                Console.WriteLine("High storm level, send out all cleaning machines.");
                break;
        }
    }
}