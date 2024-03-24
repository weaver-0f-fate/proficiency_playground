namespace Facade;

public interface ICalculatorFacade
{
    public Task<int> AddAsync(int intA, int intB);
    public Task<int> DivideAsync(int intA, int intB);
    public Task<int> MultiplyAsync(int intA, int intB);
    public Task<int> SubtractAsync(int intA, int intB);
}

public class CalculatorFacade : ICalculatorFacade
{
    private readonly ICalculator _calculator;

    public CalculatorFacade(ICalculator calculator)
    {
        _calculator = calculator;
    }
    
    public async Task<int> AddAsync(int intA, int intB)
    {
        return await _calculator.AddAsync(intA, intB);
    }

    public async Task<int> DivideAsync(int intA, int intB)
    {
        return await _calculator.DivideAsync(intA, intB);
    }

    public async Task<int> MultiplyAsync(int intA, int intB)
    {
        return await _calculator.MultiplyAsync(intA, intB);
    }

    public async Task<int> SubtractAsync(int intA, int intB)
    {
        return await _calculator.SubtractAsync(intA, intB);
    }
}