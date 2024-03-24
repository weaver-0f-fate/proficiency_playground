using Facade;
using Microsoft.Extensions.Caching.Memory;

namespace Proxy;

public interface ICalculatorsFactory
{
    public ICalculatorFacade GetOriginalCalculatorFacade();
    public ICalculatorFacade GetCalculatorFacadeWithCache();
}

public class CalculatorsFactory : ICalculatorsFactory
{
    private readonly ICalculator _calculator;
    private readonly IMemoryCache _cache;
    
    public CalculatorsFactory(ICalculator calculator, IMemoryCache cache)
    {
        _calculator = calculator;
        _cache = cache;
    }
    
    public ICalculatorFacade GetOriginalCalculatorFacade()
    {
        return new CalculatorFacade(_calculator);
    }

    public ICalculatorFacade GetCalculatorFacadeWithCache()
    {
        return new CalculatorFacadeCacheProxy(GetOriginalCalculatorFacade(), _cache);
    }
}