namespace storageApi;

public class DeliveryDetail
{
    public int DeliveryDetailId { get; set; }
    public int DeliveryQuantity { get; set; }
    public DateTime ExpectedDate { get; set; }
    public DateTime ActualDate { get; set; }
    public Product Product { get; set; } = null!;
    public Warehouse Warehouse { get; set; } = null!;
}
