using System;

namespace DILIFETIMESDEMO.classes
{
    public class NotificationService : INotificationService
    {
        public void SendNotification()
        {
            Console.WriteLine("Sending email to {customer}: Your order of {amount} has been processed.");
        }

        public NotificationService()
        {
            Guid _id = Guid.NewGuid();
            Console.WriteLine("PricingService created with Id: {_id}", _id);
        }

    }
}

