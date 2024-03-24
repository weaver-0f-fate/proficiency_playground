namespace Mediator;

public interface IConciergeMediator
{
    public void SetConciergeService(IConciergeService service);
    public void OrderTaxi(ICustomer customer);
    public void OrderMasterService(ICustomer customer);
    public void OrderFlowersDelivery(ICustomer customer);
}

public class ConciergeMediator : IConciergeMediator
{
    private IConciergeService _conciergeService;

    public void SetConciergeService(IConciergeService service)
    {
        _conciergeService = service;
    }

    public void OrderTaxi(ICustomer customer)
    {
        var respond = _conciergeService.CallTaxi(customer.GetName());
        customer.ReceiveMessage(respond);
    }

    public void OrderMasterService(ICustomer customer)
    {
        var respond = _conciergeService.CallMaster(customer.GetName());
        customer.ReceiveMessage(respond);
    }

    public void OrderFlowersDelivery(ICustomer customer)
    {
        var respond = _conciergeService.DeliverFlowers(customer.GetName());
        customer.ReceiveMessage(respond);
    }
}