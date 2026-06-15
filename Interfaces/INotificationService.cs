using System.ComponentModel.DataAnnotations;

public interface INotificationService
{
    public void SendNotification(string customer, decimal amount);
}