namespace Visitor.Visitors;

public interface IVisitor
{
    public void Visit(IDish dish);
}

public abstract class AbstractVisitor : IVisitor
{
    public static IVisitor GetCheeseVisitor() => new AddCheese();
    public static IVisitor GetBaconVisitor() => new AddBacon();
    public static IVisitor GetMushroomsVisitor() => new AddMushrooms();
    public static IVisitor GetPineapplesVisitor() => new AddPineapples();
    public static IVisitor GetSeafoodVisitor() => new AddSeafood();
    
    public abstract void Visit(IDish dish);
}