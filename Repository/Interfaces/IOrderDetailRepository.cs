namespace storageApi;

public interface IOrderDetailRepository
{
    Task<ICollection<OrderDetail>> GetOrderDetails();
    Task<OrderDetail?> GetOrderDetail(int orderDetailId);
    Task<bool> OrderDetailExists(int orderDetailId);
    Task<bool> CreateOrderDetail(OrderDetail orderDetail);
    Task<bool> RemoveOrderDetail(OrderDetail orderDetail);
    Task<bool> UpdateOrderDetail(OrderDetail orderDetail);
    Task<bool> Save();
}
