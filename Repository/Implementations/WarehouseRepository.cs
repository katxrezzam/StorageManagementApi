
using Microsoft.EntityFrameworkCore;

namespace storageApi;

public class WarehouseRepository(DataContext context) : IWarehouseRepository
{
    private readonly DataContext _context = context;

    public async Task<bool> CreateWarehouse(Warehouse warehouse)
    {
        _context.Warehouses.Add(warehouse);
        return await Save();
    }

    public async Task<Warehouse?> GetWarehouse(int warehouseId)
    {
        return await _context.Warehouses.FindAsync(warehouseId);
    }

    public async Task<ICollection<Warehouse>> GetWarehouses()
    {
        return await _context.Warehouses.ToListAsync();
    }

    public async Task<bool> RemoveWarehouse(Warehouse warehouse)
    {
        _context.Warehouses.Remove(warehouse);
        return await Save();
    }

    public async Task<bool> Save()
    {
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> UpdateWarehouse(Warehouse warehouse)
    {
        _context.Warehouses.Update(warehouse);
        return await Save();
    }

    public async Task<bool> WarehouseExists(int warehouseId)
    {
        return await _context.Warehouses.AnyAsync(w => w.WarehouseId == warehouseId);
    }
}
