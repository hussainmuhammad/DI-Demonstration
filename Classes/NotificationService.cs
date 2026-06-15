using System;

namespace DILIFETIMESDEMO.classes
{
    public class NotificationService : INotificationService
    {
        private Guid _id => Guid.NewGuid();

        public void SendNotification(string customer, decimal amount)
        {
            Console.WriteLine($"Sending email to {customer}: Your order of {amount} has been processed.");
        }

        public NotificationService()
        {
            Console.WriteLine($"Notification Service created with Id: {_id}");
        }

    }
}

