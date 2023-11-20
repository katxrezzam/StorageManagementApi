namespace storageApi;

public interface IOrderRepository
{
    Task<ICollection<Order>> GetOrders();
    Task<Order?> GetOrder(int orderId);
    Task<bool> OrderExists(int orderId);
    Task<bool> CreateOrder(Order order);
    Task<bool> RemoveOrder(Order order);
    Task<bool> UpdateOrder(Order order);
    Task<bool> Save();
}
