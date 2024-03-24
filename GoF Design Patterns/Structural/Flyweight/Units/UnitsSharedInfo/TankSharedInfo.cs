namespace Flyweight.Units.UnitsSharedInfo;

public interface ITankSharedInfo
{
    public string GetTextures();
    public string GetSounds();
}

public class TankSharedInfo : ITankSharedInfo
{
    private readonly string _tankTextures;
    private readonly string _tankSounds;

    public TankSharedInfo()
    {
        _tankTextures = "This is tank textures";
        _tankSounds = "This is tank sounds";
    }
    
    public string GetTextures()
    {
        return _tankTextures;
    }

    public string GetSounds()
    {
        return _tankSounds;
    }
}