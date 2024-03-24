namespace ChainOfResponsibility.EmergencyServices;

public class Ambulance : AbstractEmergencyService
{
    public Ambulance()
    {
        EventsToRespond = new List<EmergencyEvent>
        {
            EmergencyEvent.Fire,
            EmergencyEvent.Explosion,
            EmergencyEvent.CarAccident,
            EmergencyEvent.LossOfConsciousness
        };
    }
    
    public override void CallService(EmergencyEvent emergencyEvent)
    {
        if (EventsToRespond.Contains(emergencyEvent))
            Console.WriteLine("Ambulance was called!");
    }
}