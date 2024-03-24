namespace Command.Commands;

public class AddSeafoodCommand : AbstractCommand
{
    private AddSeafoodCommand(IPizza pizza) : base(pizza) { }

    public static ICommand GetAddSeafoodCommand(IPizza pizza)
    {
        return new AddSeafoodCommand(pizza);
    }
    
    public override void Invoke()
    {
        Pizza.AddReagent(Reagent.Seafood);
    }
}