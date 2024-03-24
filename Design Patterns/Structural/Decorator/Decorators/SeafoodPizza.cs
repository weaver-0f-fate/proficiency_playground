namespace Decorator.Decorators;

public class SeafoodPizza : PizzaDecorator
{
    public SeafoodPizza(AbstractPizza abstractPizza) : base(abstractPizza) { }


    public override void PrintInfo()
    {
        Console.WriteLine("Seafood pizza");
        AbstractPizza.PrintInfo();
    }
}