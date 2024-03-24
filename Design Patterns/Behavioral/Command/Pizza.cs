namespace Command;

public interface IPizza
{
    public void AddReagent(Reagent reagent);
    public void CookPizza();
    public void PrintInfo();
}

public class Pizza : IPizza
{
    private readonly List<Reagent> _reagents;
    private bool _isPizzaReady = false;

    public Pizza()
    {
        _reagents = new List<Reagent>();
    }

    public void AddReagent(Reagent reagent)
    {
        if(!_isPizzaReady)
            _reagents.Add(reagent);
        else
            Console.WriteLine("Cannot add new reagents to already cooked pizza");
    }

    public void CookPizza()
    {
        _isPizzaReady = true;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Pizza with: {string.Join(", ", _reagents)}");
    }
}