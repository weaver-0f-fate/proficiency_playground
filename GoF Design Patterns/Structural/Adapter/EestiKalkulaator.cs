namespace Adapter;

public interface IEestiKalkulaator
{
    public int LisadaNumbreid(int x, int y);
    public int KorrutaNumbreid(int x, int y);
    public int LahutadaNumbreid(int x, int y);
    public int AnnaJuhuslikArvÜhestSajani();
}

public class EestiKalkulaator : IEestiKalkulaator
{
    public int LisadaNumbreid(int x, int y)
    {
        return x + y;
    }

    public int KorrutaNumbreid(int x, int y)
    {
        return x * y;
    }

    public int LahutadaNumbreid(int x, int y)
    {
        return x - y;
    }

    public int AnnaJuhuslikArvÜhestSajani()
    {
        var rnd = new Random();
        return rnd.Next(1, 100);
    }
}