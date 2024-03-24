using Microsoft.Extensions.DependencyInjection;
using Visitor;
using Visitor.Visitors;

var services = new ServiceCollection()
    .AddTransient<IPizza, Pizza>()
    .BuildServiceProvider();
    
var pizza = services.GetRequiredService<IPizza>();
pizza.Accept(AbstractVisitor.GetCheeseVisitor());
pizza.Accept(AbstractVisitor.GetMushroomsVisitor());
pizza.Accept(AbstractVisitor.GetSeafoodVisitor());
pizza.PrintInfo();