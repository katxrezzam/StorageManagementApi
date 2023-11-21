namespace storageApi;

public class Warehouse
{
    public int WarehouseId { get; set; }
    public string WarehouseName { get; set; } = string.Empty;
    public string IsRefrigerated { get; set; } = string.Empty;
    public Location Location { get; set; } = null!;
    public virtual ICollection<Inventory> Inventories { get; set; } = null!;
    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = null!;
    public virtual ICollection<DeliveryDetail> DeliveryDetails { get; set; } = null!;
    public virtual ICollection<Transfer> Origins { get; set; } = null!;
    public virtual ICollection<Transfer> Destinies { get; set; } = null!;

}
