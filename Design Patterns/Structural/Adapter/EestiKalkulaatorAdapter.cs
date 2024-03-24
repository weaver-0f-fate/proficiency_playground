namespace Adapter;

public interface ICalculator
{
    public int GiveRandomNumberFromOneToHundred();
    public int MultiplyNumbers(int x, int y);
    public int SubtractNumbers(int x, int y);
    public int AddNumbers(int x, int y);
}

public class EestiCalculatorAdapter : ICalculator
{
    private readonly IEestiKalkulaator _eestiKalkulaator;
    
    public EestiCalculatorAdapter(IEestiKalkulaator eestiKalkulaator)
    {
        _eestiKalkulaator = eestiKalkulaator;
    }

    public int GiveRandomNumberFromOneToHundred()
    {
        return _eestiKalkulaator.AnnaJuhuslikArvÜhestSajani();
    }

    public int MultiplyNumbers(int x, int y)
    {
        return _eestiKalkulaator.KorrutaNumbreid(x, y);
    }

    public int SubtractNumbers(int x, int y)
    {
        return _eestiKalkulaator.LahutadaNumbreid(x, y);
    }

    public int AddNumbers(int x, int y)
    {
        return _eestiKalkulaator.LisadaNumbreid(x, y);
    }
}