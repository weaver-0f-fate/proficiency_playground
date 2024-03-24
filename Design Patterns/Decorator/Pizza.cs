namespace Decorator;

public class Pizza :  AbstractPizza
{
    public override void PrintInfo()
    {
        Console.WriteLine("Simple pizza");
    }
}