namespace storageApi;

public class Order
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public Provider Provider { get; set; } = null!;
    public ICollection<OrderDetail> OrderDetails { get; set; } = null!;
}
