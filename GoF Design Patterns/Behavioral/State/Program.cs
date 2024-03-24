using Microsoft.Extensions.DependencyInjection;
using State;

var services = new ServiceCollection()
    .AddTransient<IOven, Oven>()
    .BuildServiceProvider();

var oven = services.GetRequiredService<IOven>();

oven.HeatUp();
oven.Bake();
oven.CoolDown();
oven.CoolDown();
oven.Bake();