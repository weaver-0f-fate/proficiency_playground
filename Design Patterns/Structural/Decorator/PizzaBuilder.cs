using Decorator.Decorators;

namespace Decorator;

public interface IPizzaBuilder
{
    public AbstractPizza GetPizza();
    public PizzaBuilder WithCheese();
    public PizzaBuilder WithBacon();
    public PizzaBuilder WithPineapple();
    public PizzaBuilder WithMushrooms();
    public PizzaBuilder WithSeafood();
}

public class PizzaBuilder : IPizzaBuilder
{
    private AbstractPizza _abstractPizza;

    public PizzaBuilder()
    {
        _abstractPizza = new Pizza();
    }

    public AbstractPizza GetPizza() => _abstractPizza;

    public PizzaBuilder WithCheese()
    {
        _abstractPizza = new CheesePizza(_abstractPizza);
        return this;
    }

    public PizzaBuilder WithBacon()
    {
        _abstractPizza = new BaconPizza(_abstractPizza);
        return this;
    }

    public PizzaBuilder WithPineapple()
    {
        _abstractPizza = new PineapplePizza(_abstractPizza);
        return this;
    }

    public PizzaBuilder WithMushrooms()
    {
        _abstractPizza = new MushroomsPizza(_abstractPizza);
        return this;
    }

    public PizzaBuilder WithSeafood()
    {
        _abstractPizza = new SeafoodPizza(_abstractPizza);
        return this;
    }
}