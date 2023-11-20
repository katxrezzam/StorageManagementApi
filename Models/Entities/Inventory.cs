namespace storageApi;

public class Inventory
{
    public int InventoryId { get; set; }
    public int QuantityAvailable { get; set; }
    public int MinimumStockLevel { get; set; }
    public int MaximumStockLevel { get; set; }
    public int ReorderPoint { get; set; }
    public Product Product { get; set; } = null!;
    public Warehouse Warehouse { get; set; } = null!;
}
