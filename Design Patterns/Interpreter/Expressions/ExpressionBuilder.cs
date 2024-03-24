using Command;

namespace Interpreter.Expressions;

public interface IExpressionBuilder
{
    public IPizzaExpression BuildExpression(string input);
}

public class ExpressionBuilder : IExpressionBuilder
{
    private readonly IPizzaExpression _pizzaExpression;
    
    public ExpressionBuilder(IPizzaExpression pizzaExpression)
    {
        _pizzaExpression = pizzaExpression;
    }

    public IPizzaExpression BuildExpression(string input)
    {
        var props = input.Split(" ");

        foreach (var prop in props)
        {
            _pizzaExpression.AddCommand(prop);
        }

        return _pizzaExpression;
    }
}