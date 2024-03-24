namespace ChainOfResponsibility.EmergencyServices;

public class Firefighters : AbstractEmergencyService
{
    public Firefighters()
    {
        EventsToRespond = new List<EmergencyEvent>
        {
            EmergencyEvent.Fire,
            EmergencyEvent.Explosion,
            EmergencyEvent.CarAccident
        };
    }
    
    public override void CallService(EmergencyEvent emergencyEvent)
    {
        if (EventsToRespond.Contains(emergencyEvent))
            Console.WriteLine("Firefighters were called!");
    }
}