using Microsoft.Extensions.DependencyInjection;
using State;

/*
 * Написать программу, используя паттерн State

❑Печь для приготовления пиццы
❑Состояния:
Холодная
Готова к работе
Перегрев
И методы перехода между состояниями

А так же метод bake() который ведет себя по разному 
в зависимости от того, в каком состоянии печь - 
в не прогретом и в перегретом кидает эксепшены, 
а в нормальном - работает
 */

var services = new ServiceCollection()
    .AddTransient<IOven, Oven>()
    .BuildServiceProvider();

var oven = services.GetRequiredService<IOven>();

oven.HeatUp();
oven.Bake();
oven.CoolDown();
oven.CoolDown();
oven.Bake();