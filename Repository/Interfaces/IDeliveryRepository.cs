namespace storageApi;

public interface IDeliveryRepository
{
    Task<ICollection<Delivery>> GetDeliveries();
    Task<Delivery?> GetDelivery(int deliveryId);
    Task<bool> DeliveryExists(int deliveryId);
    Task<bool> CreateDelivery(Delivery delivery);
    Task<bool> RemoveDelivery(Delivery delivery);
    Task<bool> UpdateDelivery(Delivery delivery);
    Task<bool> Save();
}
