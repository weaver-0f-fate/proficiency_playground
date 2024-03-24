namespace Decorator.Decorators;

public class BaconPizza : PizzaDecorator
{
    public BaconPizza(AbstractPizza abstractPizza) : base(abstractPizza) { }
    
    public override void PrintInfo()
    {
        Console.WriteLine("Bacon pizza");
        AbstractPizza.PrintInfo();
    }
}