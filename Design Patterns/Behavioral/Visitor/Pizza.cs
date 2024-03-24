using Visitor.Visitors;

namespace Visitor;

public interface IDish
{
    //Parent Element
    public void Accept(IVisitor visitor);
    public void AddReagent(Reagent reagent);
}

public interface IPizza : IDish
{
    //"ElementA"
    public void PrintInfo();
}

public class Pizza : IPizza
{
    private readonly List<Reagent> _reagents;
    
    public Pizza()
    {
        _reagents = new List<Reagent>();
    }


    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }

    public void AddReagent(Reagent reagent)
    {
        _reagents.Add(reagent);
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Pizza with: {string.Join(", ", _reagents)}");
    }
}