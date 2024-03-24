namespace Decorator.Decorators;

public class MushroomsPizza : PizzaDecorator
{
    public MushroomsPizza(AbstractPizza abstractPizza) : base(abstractPizza) { }
    
    public override void PrintInfo()
    {
        Console.WriteLine("Mushroom pizza");
        AbstractPizza.PrintInfo();
    }
}