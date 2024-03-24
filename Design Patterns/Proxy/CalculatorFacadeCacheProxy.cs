using Facade;
using Microsoft.Extensions.Caching.Memory;
using Shared.Enums;

namespace Proxy;

public class CalculatorFacadeCacheProxy : ICalculatorFacade
{
    private readonly ICalculatorFacade _realCalculatorFacade;
    private readonly IMemoryCache _cache;

    private const int MillisecondsAbsoluteExpiration = 300000; // 5 minutes
    
    public CalculatorFacadeCacheProxy(ICalculatorFacade realCalculatorFacade, IMemoryCache cache)
    {
        _realCalculatorFacade = realCalculatorFacade;
        _cache = cache;
    }


    public async Task<int> AddAsync(int intA, int intB)
    {
        var operation = new Operation(CalculatorOperations.Add, intA, intB);

        if (_cache.TryGetValue(operation, out int cachedResult))
        {
            return cachedResult;
        }
        var result = await _realCalculatorFacade.AddAsync(intA, intB);
        AddValueToCache(operation, result);
        return result;
    }

    public async Task<int> DivideAsync(int intA, int intB)
    {
        var operation = new Operation(CalculatorOperations.Divide, intA, intB);

        if (_cache.TryGetValue(operation, out int cachedResult))
        {
            return cachedResult;
        }
        var result = await _realCalculatorFacade.DivideAsync(intA, intB);
        AddValueToCache(operation, result);
        return result;
    }

    public async Task<int> MultiplyAsync(int intA, int intB)
    {
        var operation = new Operation(CalculatorOperations.Multiply, intA, intB);

        if (_cache.TryGetValue(operation, out int cachedResult))
        {
            return cachedResult;
        }
        var result = await _realCalculatorFacade.MultiplyAsync(intA, intB);
        AddValueToCache(operation, result);
        return result;
    }

    public async Task<int> SubtractAsync(int intA, int intB)
    {
        var operation = new Operation(CalculatorOperations.Subtract, intA, intB);

        if (_cache.TryGetValue(operation, out int cachedResult))
        {
            return cachedResult;
        }
        var result = await _realCalculatorFacade.SubtractAsync(intA, intB);
        AddValueToCache(operation, result);
        return result;
    }

    private void AddValueToCache(Operation operation, int operationValue)
    {
        MemoryCacheEntryOptions options = new()
        {
            AbsoluteExpirationRelativeToNow =
                TimeSpan.FromMilliseconds(MillisecondsAbsoluteExpiration)
        };

        _cache.Set(operation, operationValue, options);

        Console.WriteLine($"Result of operation {operation.OperationName} with numbers: {operation.IntA} and {operation.IntB} was cached.");
    }

    private record Operation(CalculatorOperations OperationName, int IntA, int IntB);
}