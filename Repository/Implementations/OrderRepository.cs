
namespace storageApi;

public class OrderRepository(DataContext context) : IOrderRepository
{
    private readonly DataContext _context = context;

    public async Task<bool> CreateOrder(Order order)
    {
        _context.Orders.Add(order);
        return await Save();
    }

    public async Task<Order?> GetOrder(int orderId)
    {
        return await _context.Orders.FindAsync(orderId);
    }

    public Task<ICollection<Order>> GetOrders()
    {
        throw new NotImplementedException();
    }

    public Task<bool> OrderExists(int orderId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> RemoveOrder(Order order)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Save()
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateOrder(Order order)
    {
        throw new NotImplementedException();
    }
}
