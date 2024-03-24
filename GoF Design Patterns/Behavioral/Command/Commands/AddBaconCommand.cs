namespace Command.Commands;

public class AddBaconCommand : AbstractCommand
{
    private AddBaconCommand(IPizza pizza) : base(pizza) { }

    public static ICommand GetAddBaconCommand(IPizza pizza)
    {
        return new AddBaconCommand(pizza);
    }
    
    public override void Invoke()
    {
        Pizza.AddReagent(Reagent.Bacon);
    }
}