using ChainOfResponsibility.EmergencyServices;

namespace ChainOfResponsibility;

public interface IServiceCallOperator
{
    public void CallEmergencyService(EmergencyEvent emergencyEvent);
}

public class ServiceCallOperator : IServiceCallOperator
{
    private readonly List<IEmergencyService> _emergencyServices;
    
    public ServiceCallOperator()
    {
        _emergencyServices = AbstractEmergencyService.GetEmergencyServices();
    }

    public void CallEmergencyService(EmergencyEvent emergencyEvent)
    {
        Console.WriteLine($"Calling emergency services for the event: {emergencyEvent}!");
        foreach (var emergencyService in _emergencyServices)
        {
            emergencyService.CallService(emergencyEvent);
        }
    }
}