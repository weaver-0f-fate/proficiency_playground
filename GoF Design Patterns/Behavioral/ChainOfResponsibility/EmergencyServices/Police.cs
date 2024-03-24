namespace ChainOfResponsibility.EmergencyServices;

public class Police : AbstractEmergencyService
{
    public Police()
    {
        EventsToRespond = new List<EmergencyEvent>
        {
            EmergencyEvent.Fire,
            EmergencyEvent.Explosion,
            EmergencyEvent.CarAccident,
            EmergencyEvent.Robbery
        };
    }
    
    public override void CallService(EmergencyEvent emergencyEvent)
    {
        if (EventsToRespond.Contains(emergencyEvent))
            Console.WriteLine("Police was called!");
    }
}