using System;

namespace DILIFETIMESDEMO.classes
{
    public class OrderService : IOrderService
    {
        private readonly IPricingService _pricingService;
        private readonly INotificationService  _notificationService;
        private readonly IOperationTracker  _operationTracker;
        private readonly IAppLifecycleLogger  _appLogger;
        private readonly Guid _id = Guid.NewGuid();


        public void ProcessOrder(string customer, decimal amount)
        {
            var total = _pricingService.CalculateTotal(amount);
            Console.WriteLine($"Processing order for {customer} with amount {amount}.");

            _operationTracker.Increment();

            _notificationService.SendNotification();

            _appLogger.Log($"OrderService[{_id}] processed order for {customer} with total {total}");

            Console.WriteLine($"OrderService[{_id}] finished processing order for {customer}.");
        }

        public OrderService(IPricingService pricingService, INotificationService notificationService, IOperationTracker operationTracker,
            IAppLifecycleLogger appLogger)
        {
            _pricingService = pricingService;
            _notificationService = notificationService;
            _operationTracker = operationTracker;
            _appLogger = appLogger;

            Console.WriteLine($"Order Service created with Id: {_id}");
        }

    }
}

