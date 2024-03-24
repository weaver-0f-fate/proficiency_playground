namespace Command.Commands;

public class AddPineapplesCommand : AbstractCommand
{
    private AddPineapplesCommand(IPizza pizza) : base(pizza) { }

    public static ICommand GetAddPineapplesCommand(IPizza pizza)
    {
        return new AddPineapplesCommand(pizza);
    }

    public override void Invoke()
    {
        Pizza.AddReagent(Reagent.Pineapples);
    }
}