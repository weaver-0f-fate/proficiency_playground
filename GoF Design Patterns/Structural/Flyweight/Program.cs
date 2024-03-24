using Flyweight;
using Flyweight.Units.UnitsSharedInfo;
using Microsoft.Extensions.DependencyInjection;

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