using Command;
using Microsoft.Extensions.DependencyInjection;

/*
 * Написать программу, используя паттерн Command

❑Готовим пиццу
❑По кастомному рецепту от пользователя содержащему в разных сочетаниях:
❑Сыр
❑Бекон
❑Ананасы
❑Грибы
❑Морепродукты
 */

var services = new ServiceCollection();

services.AddTransient<IInvoker, Invoker>();
services.AddTransient<IPizza, Pizza>();

using var serviceProvider = services.BuildServiceProvider();
var pizza = serviceProvider.GetRequiredService<IPizza>();
var pizza2 = serviceProvider.GetRequiredService<IPizza>();
var invoker = serviceProvider.GetRequiredService<IInvoker>();

invoker.AddCheeseInvokeCommand(pizza);
invoker.AddMushroomsInvokeCommand(pizza);
invoker.AddSeafoodInvokeCommand(pizza2);


invoker.InvokeNextCommand();
invoker.InvokeNextCommand();
invoker.InvokeNextCommand();

pizza.PrintInfo();
pizza2.PrintInfo();