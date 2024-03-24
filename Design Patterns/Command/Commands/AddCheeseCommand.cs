namespace Command.Commands;

public class AddCheeseCommand : AbstractCommand
{
    private AddCheeseCommand(IPizza pizza) : base(pizza) { }

    public static ICommand GetAddCheeseCommand(IPizza pizza)
    {
        return new AddCheeseCommand(pizza);
    }
    
    public override void Invoke()
    {
        Pizza.AddReagent(Reagent.Cheese);
    }
}