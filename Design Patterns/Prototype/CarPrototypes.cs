namespace Prototype;

public static class CarPrototypes
{
    public static readonly Car SedanCar = new (CarType.Sedan, "black", "ABC123");
    public static readonly Car CargoCar = new (CarType.Cargo, "white", "ABC124");
    public static readonly Car MinivanCar = new (CarType.Minivan, "green", "ABC125");
}