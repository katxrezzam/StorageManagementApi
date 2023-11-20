namespace storageApi;

public interface IInventoryRepository
{
    Task<ICollection<Inventory>> GetInventories();
    Task<Inventory?> GetInventory(int inventoryId);
    Task<bool> InventoryExists(int inventoryId);
    Task<bool> CreateInventory(Inventory inventory);
    Task<bool> RemoveInventory(Inventory inventory);
    Task<bool> UpdateInventory(Inventory inventory);
    Task<bool> Save();
}
