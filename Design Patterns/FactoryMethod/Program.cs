using FactoryMethod;
using Microsoft.Extensions.DependencyInjection;


//создать печь для приготовления еды.
//готовит разные блюда в зависимости от поступающих параметров.

var services = new ServiceCollection();
//используем фактори метод + DI для создания объектов Oven / Menu
services.AddTransient<IMenu, Menu>();
services.AddTransient<IOven, Oven>();

using var serviceProvider = services.BuildServiceProvider();
var oven = serviceProvider.GetRequiredService<IOven>();
    
//в качестве поступающего параметра использован номер блюда в меню.
var dish = oven.Cook(2);
dish.PrintInfo();