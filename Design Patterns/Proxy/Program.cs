using Facade;
using Microsoft.Extensions.DependencyInjection;
using Proxy;

/*
 * Создайте к коду из примера Facade кеширующий прокси -
 * то есть прокси, который проверяет был ли уже такой
 * запрос и если был - отдает его из своей памяти. Если
 * нет - помещает его в память. Реализовывать очистку
 * кеша и слежение за временем доступа не надо.
 */

var services = new ServiceCollection();
services.AddMemoryCache();
services.AddHttpClient();
services.AddTransient<ICalculator, Calculator>();
services.AddTransient<ICalculatorsFactory, CalculatorsFactory>();

await using var serviceProvider = services.BuildServiceProvider();
var calculatorsFactory = serviceProvider.GetRequiredService<ICalculatorsFactory>();
var calculator = calculatorsFactory.GetCalculatorFacadeWithCache();

Console.WriteLine(await calculator.AddAsync(2, 6));
Console.WriteLine(await calculator.AddAsync(2, 6));
Console.WriteLine(await calculator.SubtractAsync(19, 6));
