namespace storageApi;

public class InventoryDto
{
    public int QuantityAvailable { get; set; }
    public int MinimumStockLevel { get; set; }
    public int MaximumStockLevel { get; set; }
    public int ReorderPoint { get; set; }
    public int ProductId { get; set; }
    public int WarehouseId { get; set; }
}
