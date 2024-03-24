using Mediator;
using Microsoft.Extensions.DependencyInjection;

/*
 * Написать программу, используя паттерн Mediator
Консьерж сервис
Можно давать задания на:
Вызов такси
Вызов мастера на дом
Доставку цветов
и нотифицировать отправителя, не связывая их напрямую
 */

var serviceProvider = new ServiceCollection()
    .AddTransient<IConciergeMediator, ConciergeMediator>()
    .BuildServiceProvider();

var mediator = serviceProvider.GetRequiredService<IConciergeMediator>();
var customer = Customer.GetCustomer(mediator);
var conciergeService = ConciergeService.GetConciergeService(mediator);
mediator.SetConciergeService(conciergeService);

customer.OrderTaxi();
Console.WriteLine("-------------");
customer.OrderMasterService();
Console.WriteLine("-------------");
customer.OrderFlowersDelivery();