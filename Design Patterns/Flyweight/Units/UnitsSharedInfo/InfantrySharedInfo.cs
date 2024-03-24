namespace Flyweight.Units.UnitsSharedInfo;

public interface IInfantrySharedInfo
{
    public string GetTextures();
    public string GetSounds();
}

public class InfantrySharedInfo : IInfantrySharedInfo
{
    private readonly string _infantryTextures;
    private readonly string _infantrySounds;

    public InfantrySharedInfo()
    {
        _infantryTextures = "This is infantry textures";
        _infantrySounds = "This is infantry sounds";
    }
    
    public string GetTextures()
    {
        return _infantryTextures;
    }

    public string GetSounds()
    {
        return _infantrySounds;
    }
}