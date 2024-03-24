using Microsoft.Extensions.DependencyInjection;
using Observer;
using Observer.Observers;

/*
 * Написать программу, используя паттерн Observer

❑Сервис предупреждения о штормах
Может извещать подписчиков о наступлении шторма
Разные подписчики - школы, аэропорт, дорожные службы реагируют на разный уровень предупреждения
 */

var serviceProvider = new ServiceCollection()
    .AddTransient<IStormWarner, StormWarner>()
    .BuildServiceProvider();

var stormWarner = serviceProvider.GetRequiredService<IStormWarner>();

var observers = AbstractStormObserver.GetDefaultStormObservers();
stormWarner.AddObservers(observers);

stormWarner.GenerateStorm(2);
stormWarner.GenerateStorm(6);
stormWarner.GenerateStorm(9);