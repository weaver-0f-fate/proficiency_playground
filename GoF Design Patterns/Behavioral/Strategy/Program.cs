using Microsoft.Extensions.DependencyInjection;
using Shared.Wrappers;
using Strategy;

var services = new ServiceCollection()
    .AddTransient<ICollectionSorter, CollectionSorter>()
    .BuildServiceProvider();

var sorter = services.GetRequiredService<ICollectionSorter>();

IEnumerable<IComparable<object>> arr = new List<IntWrapper>
    { new(1), new(5), new(9), new(2), new(4), new(6), new(8), new(3), new(10), };

Console.WriteLine($"Original: {string.Join(", ", arr)}");

var sorted1 = sorter.Sort(arr);
Console.WriteLine(string.Join(", ", sorted1));

var sorted2 = sorter.Sort(arr, new BubbleSortStrategy());
Console.WriteLine(string.Join(", ", sorted2));

var sorted3 = sorter.Sort(arr, new QuickSortStrategy());
Console.WriteLine(string.Join(", ", sorted3));