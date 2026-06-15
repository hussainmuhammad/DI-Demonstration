using System.Diagnostics;
public interface IOrderService
{
    void ProcessOrder(string customer, decimal amount);
}