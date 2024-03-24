using Microsoft.Extensions.DependencyInjection;
using Prototype;

var services = new ServiceCollection();
services.AddTransient<ICarFactory, CarFactory>();

using var serviceProvider = services.BuildServiceProvider();
var carFactory = serviceProvider.GetRequiredService<ICarFactory>();

var sedan = carFactory.CrateSedan();
sedan.SetColor("blue");
sedan.SetNumber("KDL028");
sedan.PrintInfo();