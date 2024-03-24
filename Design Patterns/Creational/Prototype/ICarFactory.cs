namespace Prototype;

public interface ICarFactory
{
    public ICar CrateSedan();
    public ICar CreateCargo();
    public ICar CreateMinivan();
}