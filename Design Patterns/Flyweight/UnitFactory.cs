using Flyweight.Units;
using Flyweight.Units.UnitsSharedInfo;

namespace Flyweight;

public interface IUnitFactory
{
    public IUnit CreateInfantry();
    public IUnit CreateTank();
}

public class UnitFactory : IUnitFactory
{
    private readonly IInfantrySharedInfo _infantrySharedInfo;
    private readonly ITankSharedInfo _tankSharedInfo;

    public UnitFactory(ITankSharedInfo tankSharedInfo, IInfantrySharedInfo infantrySharedInfo)
    {
        _tankSharedInfo = tankSharedInfo;
        _infantrySharedInfo = infantrySharedInfo;
    }
    
    public IUnit CreateInfantry()
    {
        return new Infantry(_infantrySharedInfo);
    }

    public IUnit CreateTank()
    {
        return new Tank(_tankSharedInfo);
    }
}