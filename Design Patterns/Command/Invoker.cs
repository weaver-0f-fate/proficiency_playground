using Command.Commands;

namespace Command;

public interface IInvoker
{
    public void AddCheeseInvokeCommand(IPizza pizza);
    public void AddBaconInvokeCommand(IPizza pizza);
    public void AddMushroomsInvokeCommand(IPizza pizza);
    public void AddPineapplesInvokeCommand(IPizza pizza);
    public void AddSeafoodInvokeCommand(IPizza pizza);
    public void InvokeNextCommand();
}

public class Invoker : IInvoker
{
    private readonly Queue<ICommand> _commandsToInvoke;

    public Invoker()
    {
        _commandsToInvoke = new Queue<ICommand>();
    }

    public void AddCheeseInvokeCommand(IPizza pizza)
    {
        var command = AddCheeseCommand.GetAddCheeseCommand(pizza);
        _commandsToInvoke.Enqueue(command);
    }

    public void AddBaconInvokeCommand(IPizza pizza)
    {
        var command = AddBaconCommand.GetAddBaconCommand(pizza);
        _commandsToInvoke.Enqueue(command);
    }

    public void AddMushroomsInvokeCommand(IPizza pizza)
    {
        var command = AddMushroomsCommand.GetAddMushroomsCommand(pizza);
        _commandsToInvoke.Enqueue(command);
    }

    public void AddPineapplesInvokeCommand(IPizza pizza)
    {
        var command = AddPineapplesCommand.GetAddPineapplesCommand(pizza);
        _commandsToInvoke.Enqueue(command);
    }

    public void AddSeafoodInvokeCommand(IPizza pizza)
    {
        var command = AddSeafoodCommand.GetAddSeafoodCommand(pizza);
        _commandsToInvoke.Enqueue(command);
    }

    public void InvokeNextCommand()
    {
        var command = _commandsToInvoke.Dequeue();
        command.Invoke();
    }
}