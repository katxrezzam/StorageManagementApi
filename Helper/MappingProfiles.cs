using AutoMapper;

namespace storageApi;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Customer, CustomerDto>();
        CreateMap<DeliveryDetail, DeliveryDetailDto>();
        CreateMap<Delivery, DeliveryDto>();
        CreateMap<Inventory, InventoryDto>();
        CreateMap<Location, LocationDto>();
        CreateMap<OrderDetail, OrderDetailDto>();
        CreateMap<Order, OrderDto>();
        CreateMap<Product, ProductDto>();
        CreateMap<Provider, ProviderDto>();
        CreateMap<Transfer, TransferDto>();
        CreateMap<Warehouse, WarehouseDto>();

        CreateMap<CustomerDto, Customer>();
        CreateMap<DeliveryDetailDto, DeliveryDetail>();
        CreateMap<DeliveryDto, Delivery>();
        CreateMap<InventoryDto, Inventory>();
        CreateMap<LocationDto, Location>();
        CreateMap<OrderDetailDto, OrderDetail>();
        CreateMap<OrderDto, Order>();
        CreateMap<ProductDto, Product>();
        CreateMap<ProviderDto, Provider>();
        CreateMap<TransferDto, Transfer>();
        CreateMap<WarehouseDto, Warehouse>();
    }
}
