using AbstractFactory;
using Microsoft.Extensions.DependencyInjection;
using Shared.Menu;

/*
 * Написать программу, используя паттерн Abstract Factory
❑Кафе, специализирующегося на нескольких национальных кухнях
❑Каждая кухня содержит традиционные блюда
❑Готовим комплексные обеды – для японской, американской и украинской кухни
 */
 
var services = new ServiceCollection();

services.AddTransient<IMenu, Menu>();
services.AddTransient<IOven, Oven>();
services.AddTransient<ICafe, Cafe>();

using var serviceProvider = services.BuildServiceProvider();
var cafe = serviceProvider.GetRequiredService<ICafe>();


cafe.OrderAmericanLunch();
cafe.OrderUkrainianLunch();
cafe.OrderJapaneseLunch();