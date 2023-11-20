namespace storageApi;

public class Transfer
{
    public int TransferId { get; set; }
    public int TransferQuantity { get; set; }
    public DateTime SentDate { get; set; }
    public DateTime ReceivedDate { get; set; }
    public Product Product { get; set; } = null!;
    public Warehouse Origin { get; set; } = null!;
    public int OriginId { get; set; }
    public Warehouse Destiny { get; set; } = null!;
    public int DestinyId { get; set; }
}
