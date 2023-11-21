namespace storageApi;

public class Delivery
{
    public int DeliveryId { get; set; }
    public DateTime SalesDate { get; set; }
    public Customer Customer { get; set; } = null!;
    public virtual ICollection<DeliveryDetail> DeliveryDetails { get; set; } = null!;
}
