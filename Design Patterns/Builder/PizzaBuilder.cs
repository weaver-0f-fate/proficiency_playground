namespace Builder;

public interface IPizzaBuilder
{
    public IReadyPizza GetPizza();
    public PizzaBuilder WithCheese();
    public PizzaBuilder WithBacon();
    public PizzaBuilder WithPineapple();
    public PizzaBuilder WithMushrooms();
    public PizzaBuilder WithSeafood();
}

public class PizzaBuilder : IPizzaBuilder
{
    private readonly IBuildingPizza _buildingPizza;

    public PizzaBuilder(IBuildingPizza buildingPizza)
    {
        _buildingPizza = buildingPizza;
    }
    
    public IReadyPizza GetPizza()
    {
        var readyPizza = _buildingPizza.GetPizza();
        return readyPizza;
    }

    public PizzaBuilder WithCheese()
    {
        _buildingPizza.AddReagent(Reagent.Cheese);
        return this;
    }

    public PizzaBuilder WithBacon()
    {
        _buildingPizza.AddReagent(Reagent.Bacon);
        return this;
    }

    public PizzaBuilder WithPineapple()
    {
        _buildingPizza.AddReagent(Reagent.Pineapple);
        return this;
    }

    public PizzaBuilder WithMushrooms()
    {
        _buildingPizza.AddReagent(Reagent.Mushrooms);
        return this;
    }

    public PizzaBuilder WithSeafood()
    {
        _buildingPizza.AddReagent(Reagent.Seafood);
        return this;
    }
}