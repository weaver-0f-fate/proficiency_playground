namespace Command.Commands;

public class CookPizzaCommand : AbstractCommand
{
    private CookPizzaCommand(IPizza pizza) : base(pizza) { }
    
    public static ICommand GetCookPizzaCommand(IPizza pizza)
    {
        return new CookPizzaCommand(pizza);
    }
    
    public override void Invoke()
    {
        Pizza.CookPizza();
    }
}