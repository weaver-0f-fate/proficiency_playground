using Flyweight.Units;

namespace Flyweight;

public interface IArmy
{
    public void Move(int x, int y, int z);
    public void AddInfantry();
    public void AddTank();
    public void PrintArmyUnitsAmount();
    public void PrintArmyInfo();
}

public class Army : IArmy
{
    private readonly IUnitFactory _unitFactory;
    private readonly List<IUnit> _armyUnits = new();

    public Army(IUnitFactory unitFactory)
    {
        _unitFactory = unitFactory;
    }
    
    public void Move(int x, int y, int z)
    {
        foreach (var unit in _armyUnits)
        {
            unit.Move(x, y, z);
        }
        Console.WriteLine($"Army moved to coordinates {x}, {y}, {z}");
    }

    public void AddInfantry()
    {
        _armyUnits.Add(_unitFactory.CreateInfantry());
    }

    public void AddTank()
    {
        _armyUnits.Add(_unitFactory.CreateTank());
    }

    public void PrintArmyUnitsAmount()
    {
        Console.WriteLine(_armyUnits.Count);
    }

    public void PrintArmyInfo()
    {
        foreach (var unit in _armyUnits)
        {
            unit.PrintInfo();
        }
    }
}