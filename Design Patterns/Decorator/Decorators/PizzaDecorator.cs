namespace Decorator.Decorators;

public abstract class PizzaDecorator : AbstractPizza
{
    protected AbstractPizza AbstractPizza { get; set; }

    protected PizzaDecorator(AbstractPizza abstractPizza)
    {
        AbstractPizza = abstractPizza;
    }
}