using FactoryMethod;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddTransient<IMenu, Menu>();
services.AddTransient<IOven, Oven>();

using var serviceProvider = services.BuildServiceProvider();
var oven = serviceProvider.GetRequiredService<IOven>();
    
var dish = oven.Cook(2);
dish.PrintInfo();