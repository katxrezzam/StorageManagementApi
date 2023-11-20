
using Microsoft.EntityFrameworkCore;

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

    public async Task<ICollection<Order>> GetOrders()
    {
        return await _context.Orders.ToListAsync();
    }

    public async Task<bool> OrderExists(int orderId)
    {
        return await _context.Orders.AnyAsync(o => o.OrderId == orderId);
    }

    public async Task<bool> RemoveOrder(Order order)
    {
        _context.Orders.Remove(order);
        return await Save();
    }

    public async Task<bool> Save()
    {
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> UpdateOrder(Order order)
    {
        _context.Orders.Update(order);
        return await Save();
    }
}
