namespace Mediator;

public interface ICustomer
{
    public string GetName();
    public void OrderTaxi();
    public void OrderMasterService();
    public void OrderFlowersDelivery();
    public void ReceiveMessage(string message);
}

public class Customer : ICustomer
{
    private readonly IConciergeMediator _mediator;
    private readonly string _name;
    
    private Customer(IConciergeMediator mediator)
    {
        _mediator = mediator;
        _name = Guid.NewGuid().ToString();
    }

    public static ICustomer GetCustomer(IConciergeMediator mediator)
    {
        return new Customer(mediator);
    }

    public string GetName()
    {
        return _name;
    }

    public void OrderTaxi()
    {
        _mediator.OrderTaxi(this);
    }

    public void OrderMasterService()
    {
        _mediator.OrderMasterService(this);
    }

    public void OrderFlowersDelivery()
    {
        _mediator.OrderFlowersDelivery(this);
    }

    public void ReceiveMessage(string message)
    {
        Console.WriteLine($"Customer received the message: {message}");
    }
}