using Flyweight.Units.UnitsSharedInfo;

namespace Flyweight.Units;

public class Infantry : AbstractUnit
{
    private readonly IInfantrySharedInfo _infantrySharedInfo;
    
    public Infantry(IInfantrySharedInfo infantrySharedInfo)
    {
        _infantrySharedInfo = infantrySharedInfo;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Infantry with Uuid: {Uuid} has texture: {_infantrySharedInfo.GetTextures()} and sound: {_infantrySharedInfo.GetSounds()}");
    }
}