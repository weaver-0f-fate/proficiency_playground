using Flyweight;
using Flyweight.Units.UnitsSharedInfo;
using Microsoft.Extensions.DependencyInjection;


/*
 * Напишите программу, поддерживающую работу с двумя типами юнитов
 * компьютерной игры (танки и пехота или пехота и кавалерия) так,
 * чтобы можно было включать разнородные юниты в единый список
 * (создание армии) и изменять их координаты одновременно
 * (перемещение армии). Причем так, чтобы тяжелые данные каждого
 * юнита - текстура и звуки хранились в памяти только один раз
 * для одного типа юнитов. 
 */

var services = new ServiceCollection();
services.AddSingleton<ITankSharedInfo, TankSharedInfo>();
services.AddSingleton<IInfantrySharedInfo, InfantrySharedInfo>();

services.AddTransient<IUnitFactory, UnitFactory>();
services.AddTransient<IArmy, Army>();

using var serviceProvider = services.BuildServiceProvider();

var army = serviceProvider.GetRequiredService<IArmy>();

army.AddInfantry();
army.AddTank();
army.AddTank();

army.Move(100, 100, 100);
army.PrintArmyUnitsAmount();
army.PrintArmyInfo();