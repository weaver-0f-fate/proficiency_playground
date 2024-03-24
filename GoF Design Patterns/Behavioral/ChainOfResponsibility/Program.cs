using ChainOfResponsibility;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

services.AddTransient<IServiceCallOperator, ServiceCallOperator>();

using var serviceProvider = services.BuildServiceProvider();
var serviceCaller = serviceProvider.GetRequiredService<IServiceCallOperator>();

serviceCaller.CallEmergencyService(EmergencyEvent.Explosion);
serviceCaller.CallEmergencyService(EmergencyEvent.Fire);
serviceCaller.CallEmergencyService(EmergencyEvent.CarAccident);
serviceCaller.CallEmergencyService(EmergencyEvent.LossOfConsciousness);
serviceCaller.CallEmergencyService(EmergencyEvent.Robbery);