using ChainOfResponsibility;
using Microsoft.Extensions.DependencyInjection;

/*
 * Написать программу, используя паттерн Chain of responsibility
 * 
❑Вызов экстренной службы через единый интерфейс
❑Можно вызвать:
❑Пожарных
❑Полицию
❑Медицинскую помощь
 */

var services = new ServiceCollection();

services.AddTransient<IServiceCallOperator, ServiceCallOperator>();

using var serviceProvider = services.BuildServiceProvider();
var serviceCaller = serviceProvider.GetRequiredService<IServiceCallOperator>();

serviceCaller.CallEmergencyService(EmergencyEvent.Explosion);
serviceCaller.CallEmergencyService(EmergencyEvent.Fire);
serviceCaller.CallEmergencyService(EmergencyEvent.CarAccident);
serviceCaller.CallEmergencyService(EmergencyEvent.LossOfConsciousness);
serviceCaller.CallEmergencyService(EmergencyEvent.Robbery);