namespace storageApi;

public class DeliveryDetailDto
{
    public int DeliveryQuantity { get; set; }
    public DateTime ExpectedDate { get; set; }
    public DateTime ActualDate { get; set; }
    public int ProductId { get; set; }
    public int WarehouseId { get; set; }
}
