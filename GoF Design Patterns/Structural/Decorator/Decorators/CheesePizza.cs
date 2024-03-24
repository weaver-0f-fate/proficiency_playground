namespace Decorator.Decorators;

public class CheesePizza : PizzaDecorator
{
    public CheesePizza(AbstractPizza abstractPizza) : base(abstractPizza) { }
    
    public override void PrintInfo()
    {
        Console.WriteLine("Cheese Pizza");
        AbstractPizza.PrintInfo();
    }
}