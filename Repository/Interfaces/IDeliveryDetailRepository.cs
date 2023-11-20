namespace storageApi;

public interface IDeliveryDetailRepository
{
    Task<ICollection<DeliveryDetail>> GetDeliveryDetails();
    Task<DeliveryDetail?> GetDeliveryDetail(int deliveryDetailId);
    Task<bool> DeliveryDetailExists(int deliveryDetailId);
    Task<bool> CreateDeliveryDetail(DeliveryDetail deliveryDetail);
    Task<bool> RemoveDeliveryDetail(DeliveryDetail deliveryDetail);
    Task<bool> UpdateDeliveryDetail(DeliveryDetail deliveryDetail);
    Task<bool> Save();
}
