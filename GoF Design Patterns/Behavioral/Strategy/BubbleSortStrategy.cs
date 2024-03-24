namespace Strategy;

public class BubbleSortStrategy : AbstractStrategy
{
    public override IEnumerable<object> Execute(IEnumerable<IComparable<object>> collection)
    {
        Console.WriteLine("Sorting with Bubble Sort");
        var array = collection.ToArray();

        for (var i = 0; i < array.Length - 1; i++)
        {
            for (var j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j].CompareTo(array[j + 1]) > 0)
                {
                    Swap(ref array[j], ref array[j + 1]);
                }
            }
        }

        return array;
    }

    private static void Swap(ref IComparable<object> a, ref IComparable<object> b)
    {
        (a, b) = (b, a);
    }
}
