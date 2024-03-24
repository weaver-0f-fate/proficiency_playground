using Bridge.Dishes;

namespace Bridge;

public interface IOrderFactory
{
    public IOrder MakeOrder(IEnumerable<IDish> dishes);
}

public class OrderFactory : IOrderFactory
{
    public IOrder MakeOrder(IEnumerable<IDish> dishes)
    {
        return new Order(dishes);
    }
}