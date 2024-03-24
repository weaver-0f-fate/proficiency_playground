namespace Strategy;

public interface ICollectionSorter
{
    /// <summary>
    /// Client decides which strategy we should use.
    /// </summary>
    /// <param name="collection">collection to be sorted</param>
    /// <param name="strategy">sorting strategy</param>
    public IEnumerable<object> Sort(IEnumerable<IComparable<object>> collection, IStrategy strategy);
    
    /// <summary>
    /// Collection decides which strategy it should use.
    /// </summary>
    /// <param name="collection">collection to be sorted</param>
    public IEnumerable<object> Sort(IEnumerable<IComparable<object>> collection);
}

public class CollectionSorter : ICollectionSorter
{
    public IEnumerable<object> Sort(IEnumerable<IComparable<object>> collection, IStrategy strategy)
    {
        return strategy.Execute(collection);
    }

    public IEnumerable<object> Sort(IEnumerable<IComparable<object>> collection)
    {
        var list = collection.ToList();
        return list.Count > 1000 
            ? AbstractStrategy.GetQuickSortStrategy().Execute(list) 
            : AbstractStrategy.GetBubbleSortStrategy().Execute(list);
    }
}