namespace storageApi;

public class OrderDetailDto
{
    public int OrderDetailId { get; set; }
    public int OrderQuantity { get; set; }
    public DateTime ExpectedDate { get; set; }
    public DateTime ActualDate { get; set; }
    public int OrderId { get; set; }
}
