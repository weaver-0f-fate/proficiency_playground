using Builder;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddTransient<IBuildingPizza, Pizza>();
services.AddTransient<IPizzaBuilder, PizzaBuilder>();

using var serviceProvider = services.BuildServiceProvider();


var pizzaBuilder = serviceProvider.GetRequiredService<IPizzaBuilder>();
var pizzaWithCheeseAndBacon = pizzaBuilder
 .WithCheese()
 .WithBacon()
 .GetPizza();
pizzaWithCheeseAndBacon.PrintInfo();


pizzaBuilder = serviceProvider.GetRequiredService<IPizzaBuilder>();
var pizzaWithSeafoodAndMushrooms = pizzaBuilder
 .WithMushrooms()
 .WithSeafood()
 .GetPizza();
pizzaWithSeafoodAndMushrooms.PrintInfo();


pizzaBuilder = serviceProvider.GetRequiredService<IPizzaBuilder>();
var pizzaWithPineapple = pizzaBuilder
 .WithPineapple()
 .GetPizza();
pizzaWithPineapple.PrintInfo();