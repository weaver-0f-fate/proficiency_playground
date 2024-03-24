namespace Flyweight.Units;

public interface IUnit
{
    public void Move(int x, int y, int z);
    public void PrintInfo();
}

public abstract class AbstractUnit : IUnit
{
    protected Guid Uuid { get; set; }
    public int XCoordinate { get; set; }
    public int YCoordinate { get; set; }
    public int ZCoordinate { get; set; }

    protected AbstractUnit()
    {
        Uuid = Guid.NewGuid();
    } 

    public void Move(int x, int y, int z)
    {
        XCoordinate = x;
        YCoordinate = y;
        ZCoordinate = z;
    }

    public abstract void PrintInfo();
}