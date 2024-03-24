using AbstractFactory;
using Microsoft.Extensions.DependencyInjection;
using Shared.Menu;
 
var services = new ServiceCollection();

services.AddTransient<IMenu, Menu>();
services.AddTransient<IOven, Oven>();
services.AddTransient<ICafe, Cafe>();

using var serviceProvider = services.BuildServiceProvider();
var cafe = serviceProvider.GetRequiredService<ICafe>();


cafe.OrderAmericanLunch();
cafe.OrderUkrainianLunch();
cafe.OrderJapaneseLunch();