using Bridge.Dishes;

namespace Bridge;

public interface ICafe
{
    public IOrder MakeOrder(IEnumerable<IDish> dishes);
}

public class Cafe : ICafe
{
    private readonly IOrderFactory _orderFactory;
    
    public Cafe(IOrderFactory orderFactory)
    {
        _orderFactory = orderFactory;
    }

    public IOrder MakeOrder(IEnumerable<IDish> dishes)
    {
        return _orderFactory.MakeOrder(dishes);
    }
}