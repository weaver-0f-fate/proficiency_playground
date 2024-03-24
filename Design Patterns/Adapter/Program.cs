using Adapter;
using Microsoft.Extensions.DependencyInjection;

// Создайте адаптер для класса, имеющего интерфейс на не английском языке, достаточно одного-двух методов

var services = new ServiceCollection();
services.AddTransient<IEestiKalkulaator, EestiKalkulaator>();
services.AddTransient<ICalculator, EestiCalculatorAdapter>();

using var serviceProvider = services.BuildServiceProvider();
var calculator = serviceProvider.GetRequiredService<ICalculator>();

var x = calculator.GiveRandomNumberFromOneToHundred();
var y = calculator.GiveRandomNumberFromOneToHundred();

var a = calculator.AddNumbers(x, y);
var b = calculator.MultiplyNumbers(a, x);
var c = calculator.SubtractNumbers(b, y);
Console.Write(c);