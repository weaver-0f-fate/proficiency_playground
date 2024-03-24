namespace ChainOfResponsibility.EmergencyServices;

public interface IEmergencyService
{
    public void CallService(EmergencyEvent emergencyEvent);
}

public abstract class AbstractEmergencyService : IEmergencyService
{
    protected List<EmergencyEvent> EventsToRespond;
    
    public static List<IEmergencyService> GetEmergencyServices()
    {
        return new List<IEmergencyService>
        {
            new Police(),
            new Ambulance(),
            new Firefighters()
        };
    }
    
    public abstract void CallService(EmergencyEvent emergencyEvent);
}