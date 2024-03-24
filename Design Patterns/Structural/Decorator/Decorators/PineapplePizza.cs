namespace Decorator.Decorators;

public class PineapplePizza : PizzaDecorator
{
    public PineapplePizza(AbstractPizza abstractPizza) : base(abstractPizza) { }
    
    public override void PrintInfo()
    {
        Console.WriteLine("Pineapple pizza");
        AbstractPizza.PrintInfo();
    }
}