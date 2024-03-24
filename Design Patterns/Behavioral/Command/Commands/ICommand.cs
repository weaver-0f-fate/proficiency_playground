namespace Command.Commands;

public interface ICommand
{
    public void Invoke();
}

public abstract class AbstractCommand : ICommand
{
    protected IPizza Pizza { get; set; }
    
    public abstract void Invoke();

    protected AbstractCommand(IPizza pizza)
    {
        Pizza = pizza;
    }
}