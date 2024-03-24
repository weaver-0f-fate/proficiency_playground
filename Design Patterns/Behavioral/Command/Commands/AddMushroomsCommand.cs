namespace Command.Commands;

public class AddMushroomsCommand: AbstractCommand
{
    private AddMushroomsCommand(IPizza pizza) : base(pizza) { }

    public static ICommand GetAddMushroomsCommand(IPizza pizza)
    {
        return new AddMushroomsCommand(pizza);
    }
    
    public override void Invoke()
    {
        Pizza.AddReagent(Reagent.Mushrooms);
    }
}