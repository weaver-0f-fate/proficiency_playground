using System.ComponentModel.DataAnnotations;
using Command;
using Command.Commands;

namespace Interpreter.Expressions;

public interface IPizzaExpression
{
    public void AddCommand(string input);
    public IPizza Execute();
}

public class PizzaExpression : IPizzaExpression
{
    private readonly List<ICommand> _expressionCommands;
    private readonly IPizza _pizza;
    
    public PizzaExpression(IPizza pizza)
    {
        _pizza = pizza;
        _expressionCommands = new List<ICommand>();
    }

    public void AddCommand(string input)
    {
        _expressionCommands.Add(GetCommandFromString(input));
    }

    private ICommand GetCommandFromString(string input)
    {
        return input switch
        {
            "cheese" => AddCheeseCommand.GetAddCheeseCommand(_pizza),
            "bacon" => AddBaconCommand.GetAddBaconCommand(_pizza),
            "pineapples" => AddPineapplesCommand.GetAddPineapplesCommand(_pizza),
            "mushrooms" => AddMushroomsCommand.GetAddMushroomsCommand(_pizza),
            "seafood" => AddSeafoodCommand.GetAddSeafoodCommand(_pizza),
            "cook" => CookPizzaCommand.GetCookPizzaCommand(_pizza),
            _ => throw new ValidationException("Unknown input command.")
        };
    }

    public IPizza Execute()
    {
        foreach (var command in _expressionCommands)
        {
            command.Invoke();
        }

        return _pizza;
    }
    
    
}