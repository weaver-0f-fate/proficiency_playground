using Facade;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddHttpClient();
services.AddTransient<ICalculator, Calculator>();
services.AddTransient<ICalculatorFacade, CalculatorFacade>();

await using var serviceProvider = services.BuildServiceProvider();
var calculator = serviceProvider.GetRequiredService<ICalculatorFacade>();


Console.WriteLine(await calculator.AddAsync(2, 6));
Console.WriteLine(await calculator.MultiplyAsync(2, 6));
Console.WriteLine(await calculator.SubtractAsync(19, 6));
Console.WriteLine(await calculator.DivideAsync(10, 2));

