namespace Prototype;

public class CarFactory : ICarFactory
{
    public ICar CrateSedan() => CarPrototypes.SedanCar.Clone();
    public ICar CreateCargo() => CarPrototypes.CargoCar.Clone();
    public ICar CreateMinivan() => CarPrototypes.MinivanCar.Clone();
}