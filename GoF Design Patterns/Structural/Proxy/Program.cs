using Facade;
using Microsoft.Extensions.DependencyInjection;
using Proxy;

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
