
using Microsoft.EntityFrameworkCore;

namespace storageApi;

public class DeliveryRepository(DataContext context) : IDeliveryRepository
{
    private readonly DataContext _context = context;

    public async Task<bool> CreateDelivery(Delivery delivery)
    {
        _context.Deliveries.Add(delivery);
        return await Save();
    }

    public async Task<bool> DeliveryExists(int deliveryId)
    {
        return await _context.Deliveries.AnyAsync(d => d.DeliveryId == deliveryId);
    }

    public async Task<ICollection<Delivery>> GetDeliveries()
    {
        return await _context.Deliveries.ToListAsync();
    }

    public async Task<Delivery?> GetDelivery(int deliveryId)
    {
        return await _context.Deliveries.FindAsync(deliveryId);
    }

    public async Task<bool> RemoveDelivery(Delivery delivery)
    {
        _context.Deliveries.Remove(delivery);
        return await Save();
    }

    public async Task<bool> Save()
    {
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> UpdateDelivery(Delivery delivery)
    {
        _context.Deliveries.Update(delivery);
        return await Save();
    }
}
