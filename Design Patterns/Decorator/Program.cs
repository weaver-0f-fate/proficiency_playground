using Microsoft.Extensions.DependencyInjection;
using Decorator;

/*
 * Написать программу, используя паттерн Decorator

❑Готовим пиццу
❑По кастомному рецепту от пользователя содержащему в разных сочетаниях:
❑Сыр
❑Бекон
❑Ананасы
❑Грибы
Морепродукты
 */

var services = new ServiceCollection();
services.AddTransient<IPizzaBuilder, PizzaBuilder>();

using var serviceProvider = services.BuildServiceProvider();

var pizzaBuilder = serviceProvider.GetRequiredService<IPizzaBuilder>();
var pizzaWithCheeseAndBacon = pizzaBuilder
 .WithCheese()
 .WithBacon()
 .GetPizza();
pizzaWithCheeseAndBacon.PrintInfo();
Console.WriteLine("-----------------------------");

pizzaBuilder = serviceProvider.GetRequiredService<IPizzaBuilder>();
var pizzaWithSeafoodAndMushrooms = pizzaBuilder
 .WithMushrooms()
 .WithSeafood()
 .GetPizza();
pizzaWithSeafoodAndMushrooms.PrintInfo();
Console.WriteLine("-----------------------------");

pizzaBuilder = serviceProvider.GetRequiredService<IPizzaBuilder>();
var pizzaWithPineapple = pizzaBuilder
 .WithPineapple()
 .GetPizza();
pizzaWithPineapple.PrintInfo();