namespace storageApi;

public interface IWarehouseRepository
{
    Task<ICollection<Warehouse>> GetWarehouses();
    Task<Warehouse?> GetWarehouse(int warehouseId);
    Task<bool> WarehouseExists(int warehouseId);
    Task<bool> CreateWarehouse(Warehouse warehouse);
    Task<bool> RemoveWarehouse(Warehouse warehouse);
    Task<bool> UpdateWarehouse(Warehouse warehouse);
    Task<bool> Save();
}
