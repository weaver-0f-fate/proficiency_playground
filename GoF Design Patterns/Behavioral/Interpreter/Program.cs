using Command;
using Interpreter;
using Interpreter.Expressions;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

services.AddTransient<IExpressionBuilder, ExpressionBuilder>();
services.AddTransient<IPizzaExpression, PizzaExpression>();
services.AddTransient<IInvoker, Invoker>();
services.AddTransient<IPizza, Pizza>();
services.AddTransient<IPizzaInterpreter, PizzaInterpreter>();


using var serviceProvider = services.BuildServiceProvider();

var pizzaInterpreter = serviceProvider.GetRequiredService<IPizzaInterpreter>();
var pizza = pizzaInterpreter.Interpret("cheese bacon seafood cook");
pizza.PrintInfo();

var pizzaInterpreter2 = serviceProvider.GetRequiredService<IPizzaInterpreter>();
var pizza2 = pizzaInterpreter2.Interpret("mushrooms seafood cook");
pizza2.PrintInfo();