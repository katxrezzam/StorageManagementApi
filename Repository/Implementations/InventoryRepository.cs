
using Microsoft.EntityFrameworkCore;

namespace storageApi;

public class InventoryRepository(DataContext context) : IInventoryRepository
{
    private readonly DataContext _context = context;

    public async Task<bool> CreateInventory(Inventory inventory)
    {
        _context.Inventories.Add(inventory);
        return await Save();
    }

    public async Task<ICollection<Inventory>> GetInventories()
    {
        return await _context.Inventories.ToListAsync();
    }

    public async Task<Inventory?> GetInventory(int inventoryId)
    {
        return await _context.Inventories.FindAsync(inventoryId);
    }

    public async Task<bool> InventoryExists(int inventoryId)
    {
        return await _context.Inventories.AnyAsync(i => i.InventoryId == inventoryId);
    }

    public async Task<bool> RemoveInventory(Inventory inventory)
    {
        _context.Inventories.Remove(inventory);
        return await Save();
    }

    public async Task<bool> Save()
    {
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> UpdateInventory(Inventory inventory)
    {
        _context.Inventories.Update(inventory);
        return await Save();
    }
}
