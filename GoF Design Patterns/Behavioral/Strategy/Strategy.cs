namespace Strategy;

public interface IStrategy
{
    public IEnumerable<object> Execute(IEnumerable<IComparable<object>> collection);
}

public abstract class AbstractStrategy : IStrategy
{
    public abstract IEnumerable<object> Execute(IEnumerable<IComparable<object>> collection);

    public static IStrategy GetBubbleSortStrategy()
    {
        return new BubbleSortStrategy();
    }
    
    public static IStrategy GetQuickSortStrategy()
    {
        return new QuickSortStrategy();
    }
}