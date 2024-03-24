using Microsoft.Extensions.DependencyInjection;
using Prototype;

/*
Создайте класс автомобиль, имеющий три разных предустановленных варианта (легковой, грузовой и минивен), позволяющий изменение только полей цвет и номер 
Внимание - не три класса,а  один, просто с тремя предустановленными вариантами. 
Метод клон не должен вызываться из клиентского кода. Наоборот - должны быть предоставлены методы, позволяющие создавать разные типы 
 */
var services = new ServiceCollection();
//используем фактори метод + DI для создания объектов Oven / Menu
services.AddTransient<ICarFactory, CarFactory>();

using var serviceProvider = services.BuildServiceProvider();
var carFactory = serviceProvider.GetRequiredService<ICarFactory>();

var sedan = carFactory.CrateSedan();
sedan.SetColor("blue");
sedan.SetNumber("KDL028");
sedan.PrintInfo();