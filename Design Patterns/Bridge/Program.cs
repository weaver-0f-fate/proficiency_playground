using Bridge;
using Bridge.Dishes;
using Microsoft.Extensions.DependencyInjection;

/*
 * Расширяем программу кафе, используя паттерн Bridge
❑Готовим блюдо определенной кухни
❑Первое, второе, третье и десерт
 */

var services = new ServiceCollection();

services.AddTransient<IOrderFactory, OrderFactory>();
services.AddTransient<IDishFactory, DishFactory>();
services.AddTransient<ICafe, Cafe>();

using var serviceProvider = services.BuildServiceProvider();

var dishFactory = serviceProvider.GetRequiredService<IDishFactory>();
var cafe = serviceProvider.GetRequiredService<ICafe>();

var dishes = dishFactory.GetDishes();
var desserts = dishFactory.GetDesserts();
var americanDishes = dishFactory.GetAmericanDishes();

var order = cafe.MakeOrder(dishes);
var dessertsOrder = cafe.MakeOrder(desserts);
var americanOrder = cafe.MakeOrder(americanDishes);

Console.WriteLine($"All dishes total price is {order.GetTotalPrice()}");
Console.WriteLine($"Dessert dishes total price is {dessertsOrder.GetTotalPrice()}");
Console.WriteLine($"American dishes total price is {americanOrder.GetTotalPrice()}");
