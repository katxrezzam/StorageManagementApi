namespace storageApi;

public class OrderDetail
{
    public int OrderDetailId { get; set; }
    public int OrderQuantity { get; set; }
    public DateTime ExpectedDate { get; set; }
    public DateTime ActualDate { get; set; }
    public Order Order { get; set; } = null!;
}
