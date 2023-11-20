
using Microsoft.EntityFrameworkCore;

namespace storageApi;

public class DeliveryDetailRepository(DataContext context) : IDeliveryDetailRepository
{
    private readonly DataContext _context = context;

    public async Task<bool> CreateDeliveryDetail(DeliveryDetail deliveryDetail)
    {
        _context.DeliveryDetails.Add(deliveryDetail);
        return await Save();
    }

    public async Task<bool> DeliveryDetailExists(int deliveryDetailId)
    {
        return await _context.DeliveryDetails.AnyAsync(dd => dd.DeliveryDetailId == deliveryDetailId);
    }

    public async Task<DeliveryDetail?> GetDeliveryDetail(int deliveryDetailId)
    {
        return await _context.DeliveryDetails.FindAsync(deliveryDetailId);
    }

    public async Task<ICollection<DeliveryDetail>> GetDeliveryDetails()
    {
        return await _context.DeliveryDetails.ToListAsync();
    }

    public async Task<bool> RemoveDeliveryDetail(DeliveryDetail deliveryDetail)
    {
        
        _context.DeliveryDetails.Remove(deliveryDetail);
        return await Save();
    }

    public async Task<bool> Save()
    {
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> UpdateDeliveryDetail(DeliveryDetail deliveryDetail)
    {
        _context.DeliveryDetails.Update(deliveryDetail);
        return await Save();
    }
}
