namespace Strategy;

public class QuickSortStrategy : AbstractStrategy
{
    public override IEnumerable<object> Execute(IEnumerable<IComparable<object>> collection)
    {
        Console.WriteLine("Sorting with Quick Sort");
        var array = collection.ToArray();
        QuickSortRecursive(array, 0, array.Length - 1);
        return array;
    }

    private static void QuickSortRecursive(IComparable<object>[] array, int low, int high)
    {
        if (low >= high)
            return;
        var pivotIndex = Partition(array, low, high);

        QuickSortRecursive(array, low, pivotIndex - 1);
        QuickSortRecursive(array, pivotIndex + 1, high);
    }

    private static int Partition(IComparable<object>[] array, int low, int high)
    {
        object pivot = array[high];
        var i = low - 1;

        for (var j = low; j < high; j++)
        {
            if (array[j].CompareTo(pivot) <= 0)
            {
                i++;
                Swap(ref array[i], ref array[j]);
            }
        }

        Swap(ref array[i + 1], ref array[high]);
        return i + 1;
    }

    private static void Swap(ref IComparable<object> a, ref IComparable<object> b)
    {
        (a, b) = (b, a);
    }
}