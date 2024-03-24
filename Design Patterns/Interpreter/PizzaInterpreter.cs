using Command;
using Interpreter.Expressions;

namespace Interpreter;

public interface IPizzaInterpreter
{
    public IPizza Interpret(string input);
}

public class PizzaInterpreter : IPizzaInterpreter
{
    private readonly IExpressionBuilder _expressionBuilder;
    
    public PizzaInterpreter(IExpressionBuilder expressionBuilder)
    {
        _expressionBuilder = expressionBuilder;
    }
    
    public IPizza Interpret(string input)
    {
        var expression = _expressionBuilder.BuildExpression(input);
        return expression.Execute();
    }
}