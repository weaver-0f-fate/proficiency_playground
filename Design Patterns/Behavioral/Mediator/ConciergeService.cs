namespace Mediator;

public interface IConciergeService
{
    public string CallTaxi(string customerName);
    public string CallMaster(string customerName);
    public string DeliverFlowers(string customerName);
}

public class ConciergeService : IConciergeService
{
    private readonly IConciergeMediator _mediator;
    
    private ConciergeService(IConciergeMediator mediator)
    {
        _mediator = mediator;
    }

    public static IConciergeService GetConciergeService(IConciergeMediator mediator)
    {
        return new ConciergeService(mediator);
    }

    public string CallTaxi(string customerName)
    {
        return $"Ordered taxi {Guid.NewGuid()} for customer {customerName}";
    }

    public string CallMaster(string customerName)
    {
        return $"Ordered master {Guid.NewGuid()} for customer {customerName}";
    }

    public string DeliverFlowers(string customerName)
    {
        return $"Ordered flowers delivery for customer {customerName}";
    }
}