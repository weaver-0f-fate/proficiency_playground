using Flyweight.Units.UnitsSharedInfo;

namespace Flyweight.Units;

public class Tank : AbstractUnit
{
    private readonly ITankSharedInfo _tankSharedInfo;
    
    public Tank(ITankSharedInfo tankSharedInfo)
    {
        _tankSharedInfo = tankSharedInfo;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Tank with Uuid: {Uuid} has texture: {_tankSharedInfo.GetTextures()} and sound: {_tankSharedInfo.GetSounds()}");
    }
}