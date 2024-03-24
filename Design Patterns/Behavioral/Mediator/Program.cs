using Mediator;
using Microsoft.Extensions.DependencyInjection;

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