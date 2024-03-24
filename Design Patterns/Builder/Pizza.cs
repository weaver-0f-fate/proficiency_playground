namespace Builder;

public interface IReadyPizza
{
    public void PrintInfo();
}

public interface IBuildingPizza
{
    public void AddReagent(Reagent reagent);
    public IReadyPizza GetPizza();
}

public class Pizza : IBuildingPizza, IReadyPizza
{
    private List<Reagent> Reagents { get; }

    public Pizza()
    {
        Reagents = new List<Reagent>();
    }

    public void AddReagent(Reagent reagent)
    {
        Reagents.Add(reagent);
    }

    public IReadyPizza GetPizza()
    {
        return this;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"This is pizza with: {string.Join(", ", Reagents)}.");
    }
}