namespace storageApi;

public class TransferDto
{
    public int TransferQuantity { get; set; }
    public DateTime SentDate { get; set; }
    public DateTime ReceivedDate { get; set; }
    public int ProductId { get; set; }
    public int OriginId { get; set; }
    public int DestinyId { get; set; }
}
