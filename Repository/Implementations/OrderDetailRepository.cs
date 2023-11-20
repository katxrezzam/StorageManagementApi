using Microsoft.EntityFrameworkCore;

namespace storageApi;

public class OrderDetailRepository(DataContext context) : IOrderDetailRepository
{
    private readonly DataContext _context = context;

    public async Task<bool> CreateOrderDetail(OrderDetail orderDetail)
    {
        _context.OrderDetails.Add(orderDetail);
        return await Save();
    }

    public async Task<OrderDetail?> GetOrderDetail(int orderDetailId)
    {
        return await _context.OrderDetails.FindAsync(orderDetailId);
    }

    public async Task<ICollection<OrderDetail>> GetOrderDetails()
    {
        return await _context.OrderDetails.ToListAsync();
    }

    public async Task<bool> OrderDetailExists(int orderDetailId)
    {
        return await _context.OrderDetails.AnyAsync(od => od.OrderDetailId == orderDetailId);
    }

    public async Task<bool> RemoveOrderDetail(OrderDetail orderDetail)
    {
        _context.OrderDetails.Remove(orderDetail);
        return await Save();
    }

    public async Task<bool> Save()
    {
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> UpdateOrderDetail(OrderDetail orderDetail)
    {
        _context.OrderDetails.Update(orderDetail);
        return await Save();
    }
}
