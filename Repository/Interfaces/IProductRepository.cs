namespace storageApi;

public interface IProductRepository
{
    Task<ICollection<Product>> GetProducts();
    Task<Product?> GetProduct(int productId);
    Task<bool> ProductExists(int productId);
    Task<bool> CreateProduct(Product product);
    Task<bool> RemoveProduct(Product product);
    Task<bool> UpdateProduct(Product product);
    Task<bool> Save();
}
